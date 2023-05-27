using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.CompositionsAndInheritance
{
    public class Fish : Animal
    {
        Animal fish = new Animal();

        public Fish()
        {
            fish.ToWalk();
        }
    }
}
