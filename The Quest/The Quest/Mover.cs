using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace The_Quest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;


        public bool Nearby(Point LocationToCheck, int distance)
        {
            if (Math.Abs(location.X - LocationToCheck.X) < distance &&
                (Math.Abs(location.Y - LocationToCheck.Y) < distance))
                return true;
            return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point NewLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (NewLocation.Y - MoveInterval >= boundaries.Top)
                        NewLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (NewLocation.Y + MoveInterval <= boundaries.Bottom)
                        NewLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (NewLocation.X - MoveInterval >= boundaries.Left)
                        NewLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (NewLocation.X + MoveInterval <= boundaries.Right)
                        NewLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return NewLocation;
        }
        public Mover(Point location, Game game)
        {
            this.location = location;
            this.game = game;
        }

    }
}
