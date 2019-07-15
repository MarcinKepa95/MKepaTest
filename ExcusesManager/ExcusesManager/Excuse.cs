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
            ExcusePath = path;
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }
        public void SaveFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path+".txt"))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }
        }
        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(Random random, string folder)
        {
            string[] filenames = Directory.GetFiles(folder, "*.txt");
            OpenFile(filenames[random.Next(filenames.Length)]);
        }
        public Excuse(string path)
        {
            OpenFile(path);
        }
    }
}
