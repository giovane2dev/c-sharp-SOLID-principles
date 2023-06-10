using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Picture
    {
        public override void Draw()
        {
            Console.WriteLine("This is Draw Circle Method!");
        }
    }
}
