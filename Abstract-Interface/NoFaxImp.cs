using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class NoFaxImp : IFax
    {
        public void fax()
        {
            Console.WriteLine("no fax imp");
        }
    }
}
