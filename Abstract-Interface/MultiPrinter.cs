using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class MultiPrinter : Printer, IFax
    {
        public void fax()
        {
            throw new NotImplementedException();
        }

        public override void testABS()
        {
            throw new NotImplementedException();
        }
    }
}
