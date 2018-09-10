using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class YesFaxImm : IFax
    {
        public void fax()
        {
            Console.WriteLine("yes fax imp");
        }
    }
}
