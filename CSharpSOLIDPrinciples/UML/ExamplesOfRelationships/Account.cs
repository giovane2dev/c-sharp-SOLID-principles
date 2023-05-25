using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ExamplesOfRelationships
{
    // generic class or parent class
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public double CashDeposit(double value)
        {
            return Balance - value;
        }

        public double Withdraw(double value)
        {
            return Balance + value;
        }
    }
}
