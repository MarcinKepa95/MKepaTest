using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexDisplayer_ch9_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\files\inputfiles.txt"))
            using (StreamWriter writer = new StreamWriter(@"C:\files\outputfiles.txt"))
            {
                int position = 0;

                while(!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersread = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersread;
                    for(int i=0; i<16; i++)
                    {
                        if (i < charactersread)
                        {
                            string hex = String.Format("{0:x2}", (byte)buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else writer.Write("    ");

                        if(i==7)    writer.Write("-- ");

                        if (buffer[i] < 32 || buffer[i] > 250)      buffer[i] = '.';

                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine("   " + bufferContents.Substring(0, charactersread));
                }
            }
        }
    }
}
