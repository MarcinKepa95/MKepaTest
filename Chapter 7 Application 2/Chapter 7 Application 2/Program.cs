using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Application_2
{
    class TallGuy : IClown
    {
        public string FunnyThingIHave { get { return "Big Shoes"; } }

        public void Honk()
        {
            Console.WriteLine("Honk Honk!");
        }
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height+" cm tall");
        }
        static void Main(string[] args)
        {
            ScaryScary fingerTheClown = new ScaryScary("Big Shoes", 14);
            FunnyFunny someFunnyClown = fingerTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }
    }
}
