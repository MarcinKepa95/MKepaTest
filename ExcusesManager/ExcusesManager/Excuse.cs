using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ExcusesManager
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        private void OpenFile(string path)
        {
            ExcusePath = path;
            using (Stream input = File.OpenRead(ExcusePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Excuse tempExc = (Excuse)bf.Deserialize(input);
                Description = tempExc.Description;
                Results = tempExc.Results;
                LastUsed = tempExc.LastUsed;
            }
            /*
            using (StreamReader reader = new StreamReader(path))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }*/
        }
        public void SaveFile(string path)
        {
            using (Stream output = File.Create(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
            /*
            using (StreamWriter sw = new StreamWriter(path+".txt"))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }*/
        }
        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(Random random, string folder)
        {
            string[] filenames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(filenames[random.Next(filenames.Length)]);
        }
        public Excuse(string path)
        {
            OpenFile(path);
        }
    }
}
