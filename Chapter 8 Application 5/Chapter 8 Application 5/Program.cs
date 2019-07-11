using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck {Size = 17, kindof = KindofDuck.Muscovy, Name = "Dick" },
                new Duck {Size = 18, kindof = KindofDuck.Mallard, Name = "Nick" },
                new Duck {Size = 14, kindof = KindofDuck.Decoy, Name = "Fick" },
                new Duck {Size = 11, kindof = KindofDuck.Mallard, Name = "Hick" },
                new Duck {Size = 14, kindof = KindofDuck.Muscovy, Name = "Sick" },
                new Duck {Size = 13, kindof = KindofDuck.Decoy, Name = "Bick" },
            };
            IEnumerable<Bird> upcastDucks = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feather" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "Bob" });

            foreach(Bird bird in birds)
            {
                Console.WriteLine(bird.ToString());
            }
            Console.ReadKey();
        }
    }
}
