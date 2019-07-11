using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekChapter7
{
    class OutsideWithDoor : Outside, IHasExteriorDoor, IHidingPlace
    {
        public string HidingPlace { get; private set; }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                string newDesc = base.Description + " You see " + DoorDescription + ".";
                newDesc += " There is Hiding place: " + HidingPlace + ".";
                return newDesc;
            }
        }

        public OutsideWithDoor(string name, bool hot, string DoorDescription, string HidingPlace) 
            : base(name,hot)
        {
            this.DoorDescription = DoorDescription;
            this.HidingPlace = HidingPlace;
        }
    }
}
