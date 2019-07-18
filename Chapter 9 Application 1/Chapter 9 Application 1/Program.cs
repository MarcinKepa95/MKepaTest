using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter_9_Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader reader = new StreamReader(folder + @"\secret_plan.txt");
            StreamWriter writer = new StreamWriter(folder+@"\emailToCaptainAmazing.txt");

            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We’ve discovered the Swindler’s plan:");

            while(!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();
            /*
            writer.WriteLine("How I'll defeat Captain Amazing");
            writer.WriteLine("Another genius secret plan by The Swindler");
            writer.Write("I’ll create an army of clones and ");
            writer.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            
            for(int i=0; i<=6; i++)
            {
                writer.WriteLine("Clone #{0} attacks {1}", i, location);
                if (location == "the mall") location = "downtown"; 
                else location = "the mall";
            }

            writer.Close();*/
        }
    }
}
