using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            transparencyToObject(Hero);
            transparencyToObject(table);
            transparencyToObject(attackGroupBox);
            transparencyToObject(moveGroupBox);
            transparencyToObject(Bat);
            transparencyToObject(Ghost);
            transparencyToObject(Ghoul);
            transparencyToObject(RedPotion);
            transparencyToObject(BluePotion);
            transparencyToObject(Sword);
            transparencyToObject(Bow);
            transparencyToObject(Mace);
            transparencyToObject(Weapon1);
            transparencyToObject(Weapon2);
            transparencyToObject(Weapon3);
            transparencyToObject(bluePotionInEq);
            transparencyToObject(RedPotionInEq);
        }
        private void transparencyToObject(Control control)
        {
            control.BackColor = Color.Transparent;
            control.Parent = generalBackground;
        }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private Game game;
        private Random random = new Random();
        Player player;
        private void UpdateCharacters()
        {
            Hero.Location = game.PlayerLocation;
            PlayerHP.Text = game.PlayerHitPoints.ToString();

            bool showbat = false;
            bool showghost = false;
            bool showghoul = false;
            int enemiesShown = 0;

            foreach(Enemy enemies in game.Enemies)
            {
                if (enemies is Bat)
                {
                    Bat.Location = enemies.Location;
                    BatHP.Text = enemies.HitPoints.ToString();
                    if (enemies.HitPoints > 0)
                        showbat = true;
                    enemiesShown++;
                }
                if (enemies is Ghost)
                {
                    Ghost.Location = enemies.Location;
                    GhostHP.Text = enemies.HitPoints.ToString();
                    if (enemies.HitPoints > 0)
                        showghost = true;
                    enemiesShown++;
                }
                if (enemies is Ghoul)
                {
                    Ghoul.Location = enemies.Location;
                    GhoulHP.Text = enemies.HitPoints.ToString();
                    if (enemies.HitPoints > 0)
                        showghoul = true;
                    enemiesShown++;
                }

            }
            Sword.Visible = false;
            Bow.Visible = false;
            RedPotion.Visible = false;
            BluePotion.Visible = false;
            Mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = Sword; break;
                case "Bow":
                    weaponControl = Bow; break;
                case "Mace":
                    weaponControl = Mace; break;
                case "Blue Potion":
                    weaponControl = BluePotion; break;
                case "Red Potion":
                    weaponControl = RedPotion; break;
            }
            weaponControl.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.pickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if(game.PlayerHitPoints<=0)
            {
                MessageBox.Show("U died");
                Application.Exit();
            }

            Bat.Visible = showbat;
            Ghost.Visible = showghost;
            Ghoul.Visible = showghoul;
            game.CheckPlayerEquipment(weaponControl.Name);

            Weapon1.Visible = false;
            Weapon2.Visible = false;
            Weapon3.Visible = false;
            bluePotionInEq.Visible = false;
            RedPotionInEq.Visible = false;
            foreach (string name in game.PlayerWeapons)
            {
                if(name == "Sword")
                    Weapon1.Visible = true;
                if (name == "Bow")
                    Weapon2.Visible = true; 
                if (name == "Mace")
                    Weapon3.Visible = true; 
                if (name == "Blue Potion")
                    bluePotionInEq.Visible = true; 
                if (name == "Red Potion")
                    RedPotionInEq.Visible = true; 
            }
        }
        private Label PlayerText, PlayerHP;
        private Label BatText, BatHP;
        private Label GhostText, GhostHP;
        private Label GhoulText, GhoulHP;
        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerText = new Label();
            PlayerText.Text = "Player";
            PlayerHP = new Label();
            PlayerHP.Text = "";
            BatText = new Label();
            BatText.Text = "Bat";
            BatHP = new Label();
            BatHP.Text = "";
            GhostText = new Label();
            GhostText.Text = "Ghost";
            GhostHP = new Label();
            GhostHP.Text = "";
            GhoulText= new Label();
            GhoulText.Text = "Ghoul";
            GhoulHP = new Label();
            GhoulHP.Text = "";
            table.Controls.Add(PlayerText, 0, 0);
            table.Controls.Add(PlayerHP, 1, 0);
            table.Controls.Add(BatText, 0, 1);
            table.Controls.Add(BatHP, 1, 1);
            table.Controls.Add(GhostText, 0, 2);
            table.Controls.Add(GhostHP, 1, 2);
            table.Controls.Add(GhoulText, 0, 3);
            table.Controls.Add(GhoulHP, 1, 3);
            game = new Game(new Rectangle(78, 57, 420, 155));
            player = new Player(game, game.PlayerLocation);
            game.NewLevel(random);
            UpdateCharacters();
            
        }

        private void UpMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up,random);
            UpdateCharacters();
        }

        private void DownMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void LeftMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void RightMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void Weapon1_Click(object sender, EventArgs e)
        {
            game.Equip("Sword");
        }

        private void Weapon2_Click(object sender, EventArgs e)
        {
            game.Equip("Bow");
        }

        private void Weapon3_Click(object sender, EventArgs e)
        {
            game.Equip("Mace");
        }

        private void BluePotionInEq_Click(object sender, EventArgs e)
        {
            game.Equip("Blue Potion");
        }

        private void RedPotionInEq_Click(object sender, EventArgs e)
        {
            game.Equip("Red Potion");
        }

        private void UpAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void DownAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void LeftAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void RightAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
    }
}
