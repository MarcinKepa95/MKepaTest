using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekChapter7
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlace { get; private set; }

        public override string Description
        {
            get
            {
                string newDesc = base.Description;
                newDesc += " There is Hiding place: " + HidingPlace + ".";
                return newDesc;
            }
        }

        public RoomWithHidingPlace(string Name, string decoration, string HidingPlace)
            : base(Name, decoration)
        {
            this.HidingPlace = HidingPlace;
        }
    }
}
