using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Application_3
{
    class Elephant
    {
        public string Name;
        public int Earsize;

        public void WhoAmI()
        {
           System.Windows.Forms.MessageBox.Show("My ears are " + Earsize + " inches tall", Name + " says...");
        }
    }
}
