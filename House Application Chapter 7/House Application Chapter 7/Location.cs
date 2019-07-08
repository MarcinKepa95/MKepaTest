using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Application_Chapter_7
{
    abstract class Location
    {
        public string Name { get; private set; }
        public Location[] Exits;
        public string Description
        {
            get
            {
                string Description = "You're standing in the " + Name
                    + ". You see exits to the following places: ";
                for (int i = 0; i < Exits.Length-1; i++)
                    Description += Exits[i].Name + ", ";
                Description += Exits[Exits.Length - 1].Name + ".";
                return Description;
            }
        }
    }
}
