using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Application_3
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedThis, int anotherValue)
            :base(baseClassNeedThis)
        {
            //The rest of the subclass is the same
        }
    }
}
