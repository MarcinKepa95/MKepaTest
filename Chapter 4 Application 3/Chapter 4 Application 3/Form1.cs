using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Application_3
{
    public partial class Form1 : Form
    {
        Elephant Lloyd;
        Elephant Lucinda;
        public Form1()
        {
            InitializeComponent();
            Lloyd = new Elephant() { Name = "Lloyd", Earsize = 40 };
            Lucinda = new Elephant() { Name = "Lucinda", Earsize = 33 };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Elephant swap = Lloyd;
            Lloyd = Lucinda;
            Lucinda = swap;
            MessageBox.Show("Objects swapped");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Lloyd = Lucinda;
            Lloyd.Earsize = 4321;
            Lloyd.WhoAmI();
        }
    }
}
