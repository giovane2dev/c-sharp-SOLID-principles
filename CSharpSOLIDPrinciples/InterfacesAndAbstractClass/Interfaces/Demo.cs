using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Interfaces
{
    internal class Demo : Example, IControl, ITest
    {
        public void Draw()
        {
            Console.Write("This is Draw method!");
        }

        public void Paint()
        {
            Console.Write("This is Paint method!");
        }
    }
}
