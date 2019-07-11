using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8_Application_5
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't Fly!");
        }

        public override string ToString()
        {
            return "The penguin of name: " + base.Name;
        }
    }
}
