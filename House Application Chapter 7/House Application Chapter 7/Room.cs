using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Application_Chapter_7
{
    class Room : Location
    {
        private string decoration;

        public override string Description => base.Description + " You see " + decoration + ".";

        public Room(string Name, string decoration) :base(Name)
        {
            this.decoration = decoration;
        }
    }
}
