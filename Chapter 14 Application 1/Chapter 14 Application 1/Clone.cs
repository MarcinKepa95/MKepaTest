using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Chapter_14_Application_1
{
    [Serializable]
    class Clone :IDisposable
    {
        public int Id { get; private set; }

        public void Dispose()
        {
            string filename = @"C:\Temp\Clone.dat";
            string dirname = @"C:\Temp\";
            if(!File.Exists(filename))
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("Must...serialize...object!", "Clone #" + Id + " says...");
        }
        public Clone(int Id)
        {
            this.Id = Id;
        }
        ~Clone()
        {
            MessageBox.Show("Aghhh.. U got me!", "Clone ID "+Id);
        }
    }
}
