using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Account
    {
        public Account(string text = "Default text")
        {
            Console.WriteLine(text);
        }

        public Account(int number, double balance)
        {
            if (number <= 0)
            {
                throw new ArgumentException("The number is not valid!");
            }
                

            if (balance <= 0)
            {
                throw new ArgumentException("The balance is not valid!");
            }

            Number = number;
            Balance = balance;
        }

        private int number;
        private double balance;

        // use lambda operators: =>
        // protect property accessor: private set
        public int Number { 
            get => this.number;
            private set => this.number = value;
        }
        public double Balance { 
            get => this.balance; 
            private set => this.balance = value; }

        // this balance will replaced, so the why of the "virtual"
        public virtual void CreateBalance()
        {
            Console.WriteLine("This balance is 10!");
        }
    }
}
