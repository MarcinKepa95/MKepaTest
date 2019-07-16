using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    abstract class Weapon : Mover
    {
        public abstract string Name { get; }

        public bool pickedUp { get; private set; }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance<radius;distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
        public bool Nearby(Point enemylocation, Point target, int distance)
        {
            if (Math.Abs(target.X - enemylocation.X) < distance &&
                (Math.Abs(target.Y - enemylocation.Y) < distance))
                return true;
            return false;
        }
        public Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            target = Move(direction, boundaries);
            return target;
        }
        
        public Weapon(Game game, Point location)
            :base(location,game)
        {
            pickedUp = false;
        }
    }

    class Sword : Weapon
    {
        public Sword(Game game, Point Location)
            : base(game, Location)
        {
            ;
        }

        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            if ((int)direction == 0)
            {
                if (!DamageEnemy(direction, 10, 3, random))
                    if (!DamageEnemy(direction + 1, 10, 3, random))
                        DamageEnemy((Direction)3, 10, 3, random);
            }
            else if ((int)direction == 3)
            {
                if (!DamageEnemy(direction, 10, 3, random))
                    if (!DamageEnemy((Direction)0 + 1, 10, 3, random))
                        DamageEnemy(direction - 1, 10, 3, random);
            }
            else
            {
                if (!DamageEnemy(direction, 10, 3, random))
                    if (!DamageEnemy(direction + 1, 10, 3, random))
                        DamageEnemy(direction - 1, 10, 3, random);
            }
        }
    }

    class Bow : Weapon
    {
        public Bow(Game game, Point Location)
            : base(game, Location)
        {
            ;
        }

        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }

    class Mace : Weapon
    {
        public Mace(Game game, Point Location)
            : base(game, Location)
        {
            ;
        }

        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Up, 20, 6, random);
            DamageEnemy(Direction.Down, 20, 6, random);
            DamageEnemy(Direction.Left, 20, 6, random);
            DamageEnemy(Direction.Right, 20, 6, random);
        }
    }

    class BluePotion : Weapon, IPotion
    {
        public bool used { get; private set; }

        public BluePotion(Game game, Point Location)
            : base(game, Location)
        {
        }

        public override string Name { get { return "Blue Potion"; } }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
        }
    }

    class RedPotion : Weapon, IPotion
    {
        public bool used { get; }

        public RedPotion(Game game, Point Location)
            : base(game, Location)
        {
            ;
        }

        public override string Name { get { return "Red Potion"; } }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
        }
    }

    interface IPotion
    {
        bool used { get; }
    }
}
