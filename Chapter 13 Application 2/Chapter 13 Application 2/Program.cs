using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13_Application_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "Beagle";

            Dog jake = new Dog("Jake", "Poodle");
            Dog Betty = jake;
            Betty.Name = "Betty";
            Betty.Breed = "Pit bull";

            bob.Speak();
            jake.Speak();
            Console.ReadKey();
        }
        public struct Dog
        {
            public string Name;
            public string Breed;

            public Dog(string Name, string Breed)
            {
                this.Name = Name;
                this.Breed = Breed;
            }

            public void Speak()
            {
                Console.WriteLine("My name is {0} and I'm a {1}.", Name, Breed);
            }
        }
    }
    class Canine
    {
        public string Name;
        public string Breed;

        public Canine(string Name, string Breed)
        {
            this.Name = Name;
            this.Breed = Breed;
        }

        public void Speak()
        {
            Console.WriteLine("My name is {0} and I'm a {1}.", Name, Breed);
        }
    }
}
