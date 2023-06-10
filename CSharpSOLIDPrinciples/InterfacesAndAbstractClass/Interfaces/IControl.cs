using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Interfaces
{
    internal interface IControl
    {
        void Draw();
        void RedDraw()
        {
            Console.WriteLine("Default Member Interface");
        }
    }
}
