using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_5
{
    public enum KindofDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }

    class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindofDuck kindof;

        public int CompareTo(Duck other)
        {
            if (Size > other.Size)
                return 1;
            if (Size < other.Size)
                return -1;
            return 0;
        }
        public override string ToString()
        {
            return "A " + Size + " Inch " + kindof.ToString();
        }
    }
}
