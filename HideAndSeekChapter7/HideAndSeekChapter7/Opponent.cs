using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekChapter7
{
    class Opponent
    {
        public Location myLocation;
        private Random random = new Random();

        public void Move()
        {
            do
            {
                if (myLocation is IHasExteriorDoor)
                {
                    if (random.Next(2) == 1)
                    {
                        IHasExteriorDoor ext = myLocation as IHasExteriorDoor;
                        myLocation = ext.DoorLocation;
                    } else myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                }   else myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
            } while (!(myLocation is IHidingPlace));
        }

        public bool Check(Location CheckLocation)
        {
            if (CheckLocation == myLocation)
                return true;
            return false;
        }
        public Opponent(Location startingLocation)
        {
            random = new Random();
            myLocation = startingLocation;
        }
    }
}
