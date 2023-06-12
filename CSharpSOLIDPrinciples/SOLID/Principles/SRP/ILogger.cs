using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.SRP
{
    internal interface ILogger
    {
        void Info(string message);
    }
}
