using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    public interface IWritable
    {
        void write(TextWriter writer);
    }
    public class Writable : IWritable
    {
        public void write(TextWriter writer)
        {
            writer.WriteLine("Hello Wold");
            writer.Write("Printing Using Write........");
        }
    }
}