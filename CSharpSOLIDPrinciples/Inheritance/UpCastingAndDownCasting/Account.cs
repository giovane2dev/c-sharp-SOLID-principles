using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.UpCastingAndDownCasting
{
    public class Account
    {
        public virtual void Calc()
        {
            Console.WriteLine("Calculate from parent class");
        }
    }
}
