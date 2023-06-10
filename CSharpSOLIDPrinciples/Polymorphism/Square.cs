using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Picture
    {
        public override void Draw()
        {
            Console.WriteLine("This is Draw Square Method!");
        }

        public void Draw(string? description)
        {
            Console.WriteLine(description);
        }
    }
}
