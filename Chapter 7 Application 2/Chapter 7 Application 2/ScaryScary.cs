using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Application_2
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get
            {
                return numberOfScaryThings + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }

        public ScaryScary(string ftih, int nost) : base(ftih)
        {
            numberOfScaryThings = nost;
        }
    }
}
