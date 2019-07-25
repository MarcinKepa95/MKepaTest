using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Fan
    {
        Ball ball;
        public Fan(Ball ball)
        {
            this.ball = ball;
            ball.BallInPlay += new EventHandler<BallEventArgs>(Ball_BallInPlay);
        }

        void Ball_BallInPlay(Object sender, BallEventArgs e)
        {
            if (e.Distance >= 80 && e.Trajectory >= 20)
                Console.WriteLine("I Catch the ball! ~Fan");
        }
    }
}
