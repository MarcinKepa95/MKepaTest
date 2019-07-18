using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace The_Quest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
        public bool Dead { get { if (HitPoints <= 0) return true; else return false; } }

        public Enemy(Game game, Point location, int hitPoints)
            : base(location,game)
        {
            this.HitPoints = hitPoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y > location.Y)
                directionToMove = Direction.Down;
            else directionToMove = Direction.Up;
            return directionToMove;
        }
    }

    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        {
            ;
        }
        public override void Move(Random random)
        {
            if (random.Next(10) < 5)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else location = Move((Direction)random.Next(0, 3), game.Boundaries);

            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        {
            ;
        }
        public override void Move(Random random)
        {
            if (random.Next(9) < 3)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else location = Move((Direction)random.Next(0, 3), game.Boundaries);

            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }

    class Ghoul: Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        {
            ;
        }
        public override void Move(Random random)
        {
            if (random.Next(9) < 6)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            else location = Move((Direction)random.Next(0, 3), game.Boundaries);

            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
