using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();

        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach(Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                    Console.WriteLine(weapon.Name);
                }
                return names;
            }
        }

        public void Hit(int MaxDmg, Random random)
        {
            HitPoints -= random.Next(1, MaxDmg);
        }
        
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string WeaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if(weapon.Name == WeaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public Player(Game game, Point location)
            : base(location, game)
        {
            HitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if(!game.WeaponInRoom.pickedUp)
            {
                if(Nearby(game.WeaponInRoom.Location,10))

                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null)
                return;
            equippedWeapon.Attack(direction,random);

        }

    }
}
