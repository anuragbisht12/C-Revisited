/*
The FileStream class in the System.IO namespace helps in reading from, 
writing to and closing files. This class derives from the abstract class Stream.

*/

using System;
using System.IO;

namespace FileIOApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
               FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}

