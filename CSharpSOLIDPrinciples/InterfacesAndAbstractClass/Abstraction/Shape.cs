using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Abstraction
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public string Description()
        {
            return "I'm shape abstract class";
        }
    }
}
