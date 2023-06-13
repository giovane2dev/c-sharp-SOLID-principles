using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.LSP.Violation.Example2
{
    public class CalculateSum : Calculate
    {
        protected readonly int[] numbers;

        public CalculateSum(int[] numbers)
        {
            this.numbers = numbers;
        }

        public override int Calc() => this.numbers.Sum();
    }
}
