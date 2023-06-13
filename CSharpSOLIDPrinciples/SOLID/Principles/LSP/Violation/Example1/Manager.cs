using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.LSP.Violation.Example1
{
    internal class Manager : Employee
    {
        public double bonus = 3000;

        public Manager(string? name, string? function) : base(name, function)
        {

        }

        public override double CalculateSalary(double salary)
        {
            return salary + this.bonus;
        }
    }
}
