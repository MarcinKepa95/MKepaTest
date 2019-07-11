using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Application_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void togglebouncing(int index, Label labeltoBounce)
        {
            if(bouncers[index]==null)
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labeltoBounce;
            }
            else
            {
                bouncers[index] = null;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            togglebouncing(0, label1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            togglebouncing(1, label2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            togglebouncing(2, label3);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                if (bouncers[i] != null) bouncers[i].Move();
            }
        }
    }
}
