using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Umpire
    {
        Ball ball;

        public Umpire(Ball ball)
        {
            this.ball = ball;
            ball.BallInPlay += new EventHandler<BallEventArgs>(Ball_BallInPlay);
        }

        void Ball_BallInPlay(Object sender, BallEventArgs e)
        {
            Console.WriteLine("Distance: " + e.Distance + " Trajectory: " + e.Trajectory);
            if((e.Distance<80 && e.Trajectory>=10 && e.Trajectory<20) || e.Distance<60)
            Console.WriteLine("You're Out! ~Umpire");
        }
    }
}
