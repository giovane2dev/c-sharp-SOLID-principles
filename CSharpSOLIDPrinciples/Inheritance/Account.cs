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

        private int number;
        private double balance;

        // use lambda operators: =>
        // protect property accessor: private set
        public int Number { 
            get => this.number;
            set => this.number = value;
        }
        public double Balance { 
            get => this.balance; 
            set => this.balance = value; }

        // this balance will replaced, so the why of the "virtual"
        public virtual void CreateBalance()
        {
            Console.WriteLine("This balance is 10!");
        }
    }
}
