using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Application_Chapter_7
{
    class Outside : Location
    {
        private bool hot;

        public override string Description
        {
            get
            {
                string desc = base.Description;
                if (hot)
                    return desc += " It's very hot.";
                else return desc;
            }
        }
        public Outside(string Name, bool hot)
            : base(Name)
        {
            this.hot = hot;
        }
    }
}
