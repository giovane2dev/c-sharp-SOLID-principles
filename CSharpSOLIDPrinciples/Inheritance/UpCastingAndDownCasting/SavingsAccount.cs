using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.UpCastingAndDownCasting
{
    public class SavingsAccount : Account
    {
        public override void Calc()
        {
            Console.WriteLine("Calculate from child class");
        }

        public void GetCalc()
        {
            Console.WriteLine("Get result from child class");
        }
    }
}
