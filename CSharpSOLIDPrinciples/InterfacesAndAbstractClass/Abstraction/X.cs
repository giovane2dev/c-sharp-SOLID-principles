using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Abstraction
{
    public class X
    {
        protected virtual void Test()
        {
            Console.WriteLine("Sealed modifier test");
        }
    }
}
