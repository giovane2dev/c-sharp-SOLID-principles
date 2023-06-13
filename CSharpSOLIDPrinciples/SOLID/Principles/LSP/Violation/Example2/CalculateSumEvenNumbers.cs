using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.LSP.Violation.Example2
{
    public class CalculateSumEvenNumbers : Calculate
    {
        protected readonly int[] numbers;

        public CalculateSumEvenNumbers(int[] numbers)
        {
            this.numbers = numbers;
        }

        // method hiding
        public override int Calc() => numbers.Where(x => x % 2 == 0).Sum();
    }
}
