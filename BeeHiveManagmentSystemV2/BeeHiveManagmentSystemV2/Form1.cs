using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagmentSystemV2
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers, 275);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += queen.WorktheNextShift();
        }

        private void JobAssign_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)numericUpDown1.Value) == false)
                MessageBox.Show("No worker available to do the job " + comboBox1.Text,
                    "The queens bee says...");
            else MessageBox.Show("The job " + comboBox1.Text + " will be done in "
                + numericUpDown1.Value + " shifts", "The queens bee says...");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
