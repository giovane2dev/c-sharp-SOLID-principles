using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ExamplesOfRelationships
{
    // specialized class or child class
    public class SavingsAccount : Account
    {
        public DateTime DateOfBirth { get; set; }

        public double CreditInterest(double value)
        {
            return Balance + value;
        }
    }
}
