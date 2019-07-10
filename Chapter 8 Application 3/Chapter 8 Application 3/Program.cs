using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<duck> ducks = new List<duck>()
            {
                new duck() {Kind = KindOfDuck.Mallard, Size = 17 },
                new duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
                new duck() {Kind = KindOfDuck.Decoy, Size = 14 },
                new duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
                new duck() {Kind = KindOfDuck.Mallard, Size = 14 },
                new duck() {Kind = KindOfDuck.Decoy, Size = 13 }
            };
            foreach (duck duck in ducks)
            {
                Console.WriteLine("Duck size: " + duck.Size + " Duck Kind of: " + duck.Kind);
            }
            Console.WriteLine();
            ducks.Sort();
            foreach(duck duck in ducks)
            {
                Console.WriteLine("Duck size: " + duck.Size + " Duck Kind of: " + duck.Kind);
            }
            Console.ReadKey();
        }
    }

    public enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
    public class duck : IComparable<duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            if (this.Size < duckToCompare.Size)
                return -1;
            return 0;
        }
    }
}
