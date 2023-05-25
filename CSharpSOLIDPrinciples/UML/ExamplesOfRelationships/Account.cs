using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ExamplesOfRelationships
{
    // generalized class or parent class
    // part of the bank class (for relationship of composition type)
    public class Account : IDisposable
    {
        private Bank bank;
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

        public Account()
        {

        }

        internal Account(Bank bank)
        {
            this.bank = bank;
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
