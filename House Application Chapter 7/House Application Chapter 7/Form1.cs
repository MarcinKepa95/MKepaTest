using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Application_Chapter_7
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room DiningRoom;
        RoomWithDoor Kitchen;

        OutsideWithDoor FrontYard;
        OutsideWithDoor BackYard;
        Outside Garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
            
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet",
                "An oak door with a brass knob");
            DiningRoom = new Room("Dining Room", "A crystal chandelier");
            Kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "a screen door");
            FrontYard = new OutsideWithDoor("Front Yard", false, "An oak door with a brass knob");
            BackYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            Garden = new Outside("Garden", false);

            DiningRoom.Exits = new Location[] { livingRoom, Kitchen };
            livingRoom.Exits = new Location[] { DiningRoom };
            Kitchen.Exits = new Location[] { DiningRoom };
            FrontYard.Exits = new Location[] { BackYard, Garden };
            BackYard.Exits = new Location[] { FrontYard, Garden };
            Garden.Exits = new Location[] { BackYard, FrontYard };


            livingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = livingRoom;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = FrontYard;
        }

        private void MoveToANewLocation(Location newLocation)
        {
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
        }

        private void GoOutside_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
