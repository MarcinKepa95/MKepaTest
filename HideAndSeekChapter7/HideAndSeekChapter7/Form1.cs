using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeekChapter7
{
    public partial class Form1 : Form
    {
        int moves = 0;
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room DiningRoom;
        RoomWithDoor Kitchen;
        Room stairs;
        RoomWithHidingPlace upstairsHallway;
        RoomWithHidingPlace MasterBedroom;
        RoomWithHidingPlace SecondBedroom;
        RoomWithHidingPlace Bathroom;

        OutsideWithDoor FrontYard;
        OutsideWithDoor BackYard;
        OutsideWithHidingPlace Garden;
        OutsideWithHidingPlace driveWay;


        Opponent opponent;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
            setbuttonVisible(false);
        }

        public void setbuttonVisible(bool visible)
        {
            GoHere.Visible = visible;
            CheckButton.Visible = visible;
            GoOutside.Visible = visible;
            Exits.Visible = visible;
            HideButton.Visible = !visible;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                "An oak door with a brass knob", "closet");
            DiningRoom = new Room("Dining Room", "A crystal chandelier");
            Kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "a screen door", "cabinet");
            stairs = new Room("Stairs", "Wooden Bannister");
            upstairsHallway = new RoomWithHidingPlace("Upstairs hallway", 
                "Picture of a dog", "closet");
            MasterBedroom = new RoomWithHidingPlace("Master bedroom",
                "computer", "Large bed");
            SecondBedroom = new RoomWithHidingPlace("Second bedroom",
                "bookshelf", "Small bed");
            Bathroom = new RoomWithHidingPlace("Bathroom",
                "sink and toilet", "shower");


            FrontYard = new OutsideWithDoor("Front Yard", false, 
                "An oak door with a brass knob", "bush");
            BackYard = new OutsideWithDoor("Back Yard", true, "a screen door", 
                "bush");
            Garden = new OutsideWithHidingPlace("Garden", false, "shed");
            driveWay = new OutsideWithHidingPlace("drive Way", false, "garage");

            DiningRoom.Exits = new Location[] { livingRoom, Kitchen };
            livingRoom.Exits = new Location[] { DiningRoom, stairs };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { stairs, MasterBedroom,
                SecondBedroom, Bathroom };
            MasterBedroom.Exits = new Location[] { upstairsHallway };
            SecondBedroom.Exits = new Location[] { upstairsHallway };
            Bathroom.Exits = new Location[] { upstairsHallway };
            Kitchen.Exits = new Location[] { DiningRoom };


            FrontYard.Exits = new Location[] { BackYard, Garden, driveWay };
            BackYard.Exits = new Location[] { FrontYard, Garden, driveWay };
            driveWay.Exits = new Location[] { FrontYard, BackYard };
            Garden.Exits = new Location[] { BackYard, FrontYard };


            livingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = livingRoom;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = FrontYard;


            opponent = new Opponent(FrontYard);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            moves++;
            currentLocation = newLocation;

            Exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                Exits.Items.Add(currentLocation.Exits[i].Name);
            Exits.SelectedIndex = 0;

            Description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
            {
                GoOutside.Visible = true;
            }
            else GoOutside.Visible = false;
        }

        private void GoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[Exits.SelectedIndex]);
            if (currentLocation is IHidingPlace)
                CheckButton.Visible = true;
            else CheckButton.Visible = false;
        }

        private void GoOutside_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
        private void HideButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            z = 1;
            moves = 0;

        }

        int z;
        private void Timer1_Tick(object sender, EventArgs e)
        {
                opponent.Move();
            Description.Text = z.ToString();
            z++;
            if (z >= 11)
            {
                setbuttonVisible(true);
                timer1.Stop();
                timer1.Enabled = false;
            }


        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (opponent.Check(currentLocation))
                ResetGame();
            else Description.Text = "Opponent isn't in this place!";
        }

        public void ResetGame()
        {
            IHidingPlace ihp = opponent.myLocation as IHidingPlace;
            Description.Text = "You found opponent in " + 
                opponent.myLocation.Name + " hiding in " + ihp.HidingPlace + 
                ". You did it in only "+moves+" steps!";
            opponent.myLocation = FrontYard;
            setbuttonVisible(false);
        }
    }
}
