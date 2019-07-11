using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7_Application_2
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string ftih)
        {
            funnyThingIHave = ftih;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return "Hi kids! I have a " + funnyThingIHave;
            }
        }
        public void Honk()
        {
            Console.WriteLine("Hi kids! I have a " + funnyThingIHave);
        }

    }
}
