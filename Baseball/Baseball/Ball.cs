using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;

        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if(ballInPlay!=null)
            BallInPlay(this, e);
        }
    }

    class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }

        public int Distance { get; private set; }

        public BallEventArgs(int trajectory, int distance)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
}
