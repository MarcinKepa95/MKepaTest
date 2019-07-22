using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Class1
    {
        public int i = 0;
        public void zmieni()
    {
        i = (5 * 3 / 2 - 7 + 123) - 43;
    }
        public Class1()
        {
            GC.Collect();
        }
    }
