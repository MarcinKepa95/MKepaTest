using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5_Application_2
{
    class Farmer
    {
        public int BagsOfFeed;
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
                MessageBox.Show("Numbers of Cows: "+numberOfCows+"\nBags of Feed: "+BagsOfFeed);
            }
        }
        public Farmer(int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
        }
    }
}
