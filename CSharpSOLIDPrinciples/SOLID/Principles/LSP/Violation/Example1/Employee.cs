using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.LSP.Violation.Example1
{
    internal class Employee
    {
        public string? Name { get; set; }
        public string? Function { get; set; }

        public Employee(string? name, string? function)
        {
            this.Name = name;
            this.Function = function;
        }

        // new method in base class for resolve violation issue

        public virtual double CalculateSalary(double salary)
        {
            return salary;
        }
    }
}
