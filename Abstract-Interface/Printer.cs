using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class Printer
    {
        public string type { get; set; }
        public IFax ifax { get; set; }

        public abstract void testABS();

        public Printer()
        {
        }

        public Printer(string type)
        {
            this.type = type;
        }

        public void print()
        {
            Console.WriteLine("Printed with " + type);
        }

        public void fax()
        {
            getFax().fax();
        }

        public IFax getFax()
        {
            return ifax;
        }

        public void setIFax(IFax ifax)
        {
            this.ifax = ifax;
        }
    }
}
