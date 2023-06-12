using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.SRP
{
    internal class RegisterLog : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
