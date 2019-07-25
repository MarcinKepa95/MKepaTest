using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Pitcher
    {
        Ball ball;

        public Pitcher(Ball ball)
        {
            this.ball = ball;
            ball.BallInPlay += new EventHandler<BallEventArgs>(Ball_BallInPlay);
        }
        void Ball_BallInPlay(Object sender, BallEventArgs e)
        {
            if(e.Distance <80 && e.Distance >= 60 && e.Trajectory<10)
            Console.WriteLine("I Poke it! ~Pitcher");
        }
    }
}
