using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter_9_Application_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int intvalue = 48769414;
            string stringvalue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatvalue = 491.695f;
            char charValue = 'E';

            using (FileStream output = File.Create("binarydata.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intvalue);
                writer.Write(stringvalue);
                writer.Write(byteArray);
                writer.Write(floatvalue);
                writer.Write(charValue);
            }

            byte[] datawritten = File.ReadAllBytes("binarydata.dat");
            foreach (byte b in datawritten)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine();
            foreach (byte b in datawritten)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine(" - {0} bytes", datawritten.Length);
            Console.ReadKey();

            int intread;
            string stringread;
            byte[] byteread;
            float floatread;
            char charread;

            using (FileStream input = File.OpenRead("binarydata.dat"))
            using (BinaryReader reader = new BinaryReader(input))
            {
                intread = reader.ReadInt32();
                stringread = reader.ReadString();
                byteread = reader.ReadBytes(4);
                floatread = reader.ReadSingle();
                charread = reader.ReadChar();
            }
            Console.Write("int: {0} string: {1} bytes: ", intread, stringread);
            foreach(byte b in byteread)
            {
                Console.Write("{0} ",b);
            }
            Console.Write("float: {0} char: {1}", floatread, charread);
            Console.ReadKey();

        }
    }
}
