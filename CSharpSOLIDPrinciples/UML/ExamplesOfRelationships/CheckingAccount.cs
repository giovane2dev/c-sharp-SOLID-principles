using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ExamplesOfRelationships
{
    // specialized class or child class
    public class CheckingAccount : Account
    {
        /*
        internal CheckingAccount(Bank bank) : base(bank)
        {
        }
        */

        public double Limit { get; set; }
        public double InterestDiscount(double value)
        {
            return Balance - value;
        }
    }
}
