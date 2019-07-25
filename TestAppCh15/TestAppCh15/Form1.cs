using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppCh15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(b1);
        }
        private void b1(object sender, EventArgs e)
        {
            MessageBox.Show("b1");
        }
        private void b2(object sender, EventArgs e)
        {
            MessageBox.Show("b2");
        }

        private void F1Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 Clicked");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(b2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(F1Clicked);
        }
    }
}
