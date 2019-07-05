using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Application_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass klasa = new MyBaseClass("Tekst");
            MyBaseClass klasa2 = new MySubclass("Tekst",2);

        }
    }
}
