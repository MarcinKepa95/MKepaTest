using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Application_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { randomizer = new Random() };
            label1.Text = menu.GetMenuItems();
            label2.Text = menu.GetMenuItems();
            label3.Text = menu.GetMenuItems();
            label4.Text = menu.GetMenuItems();
            label5.Text = menu.GetMenuItems();
            label6.Text = menu.GetMenuItems();

        }
    }
}
