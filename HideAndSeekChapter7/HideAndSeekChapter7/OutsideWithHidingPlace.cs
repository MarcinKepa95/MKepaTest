using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekChapter7
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
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

        public OutsideWithHidingPlace(string Name, bool hot, string HidingPlace) 
            :base(Name, hot)
        {
            this.HidingPlace = HidingPlace;
        }
    }
}
