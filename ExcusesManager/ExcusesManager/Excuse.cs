using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExcusesManager
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        private void OpenFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                DateTime.Parse(reader.ReadLine());
            }
        }
        public void SaveFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path+@"\"+Description))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed.ToString());
            }
        }
        public Excuse()
        {
            ;
        }
        public Excuse(string Description, string Results, string ExcusePath)
        {
            this.Description = Description;
            this.Results = Results;
            this.ExcusePath = ExcusePath;
        }
        public Excuse(string path)
        {
            OpenFile(path);
            ExcusePath = path;
        }
    }
}
