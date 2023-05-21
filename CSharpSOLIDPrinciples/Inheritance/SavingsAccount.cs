using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SavingsAccount : Account
    {
        // use "base" to transfer parameter to base class
        public SavingsAccount(string text) : base(text)
        {
            
        }

        public override void CreateBalance()
        {
            Console.WriteLine("This balance is 20!");
        }
    }
}
