using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Application_Chapter_7
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public override string Description => base.Description + " You see " + DoorDescription + ".";

        public OutsideWithDoor(string name, bool hot, string DoorDescription) 
            : base(name,hot)
        {
            this.DoorDescription = DoorDescription;
        }
    }
}
