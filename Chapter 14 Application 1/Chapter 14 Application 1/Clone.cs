using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_14_Application_1
{
    class Clone :IDisposable
    {
        public int Id { get; private set; }

        public void Dispose()
        {
            MessageBox.Show("Im disposed", "Clone ID " + Id);
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
