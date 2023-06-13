using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.LSP.Violation.Example1
{
    internal class Seller : Employee
    {
        public double comission = 1500;

        public Seller(string? name, string? function) : base (name, function)
        {

        }

        public override double CalculateSalary(double salary)
        {
            return salary + this.comission;
        }
    }
}
