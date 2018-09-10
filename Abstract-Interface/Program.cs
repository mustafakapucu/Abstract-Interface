using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer multi = new MultiPrinter();
            multi.setIFax(new YesFaxImm());
            multi.fax();

            Console.ReadLine();

        }
    }
}
