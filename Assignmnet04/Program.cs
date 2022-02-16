using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            Writable writable = new Writable();
            using (TextWriter writer = File.CreateText("d:\\test.txt"))
            {
                writable.write(writer);
            }
            Console.WriteLine("File Created Success.");
            Console.ReadLine();

        }
    }
}