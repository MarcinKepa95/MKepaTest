using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_3_Application_1
{
    class Talker
    {
        public static int blahblahblah(string ThingToSay, int numberOfTimes)
        {
            string finalstring = "";
            for(int i=0; i<numberOfTimes;i++)
            {
                finalstring += ThingToSay + "\n";
            }
            MessageBox.Show(finalstring);
            return finalstring.Length;
        }
    }
}
