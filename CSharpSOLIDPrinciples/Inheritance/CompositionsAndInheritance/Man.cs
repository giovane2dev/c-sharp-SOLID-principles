using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.CompositionsAndInheritance
{
    public class Man
    {
        Animal man = new Animal();

        public Man()
        {
            man.ToWalk();
        }
    }
}
