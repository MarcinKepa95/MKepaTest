using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcusesManager
{
    public partial class Form1 : Form
    {
        private Excuse currentexcuse;
        private bool formChanged = false;
        private string Folder = "";
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            currentexcuse = new Excuse();
            if(currentexcuse != null)
                currentexcuse.LastUsed = lastUsed.Value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Folder;
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Folder = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentexcuse.Description;
                this.results.Text = currentexcuse.Results;
                this.lastUsed.Value = currentexcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentexcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentexcuse.ExcusePath).ToString();
                    this.Text = "Excuse Manager";
                }
            }
            else
                this.Text = "Excuse Manager*";
                this.formChanged = changed;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = Folder;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentexcuse.SaveFile(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse Written");
            }
        }
        private bool CheckChanged()
        {
            if (formChanged)
                if (MessageBox.Show("The current excuse has not been saved. Continue?", 
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return false;
            return true;

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            currentexcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void Results_TextChanged(object sender, EventArgs e)
        {
            currentexcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void LastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentexcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                openFileDialog1.InitialDirectory = Folder;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                //openFileDialog1.FileName = description.Text + ".txt";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentexcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            currentexcuse = new Excuse(rand, Folder);
            UpdateForm(false);
        }
    }
}
