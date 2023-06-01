using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Abstraction
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override void CalculateArea()
        {
            Area = Side * Side;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 4 * Side;
        }
    }
}
