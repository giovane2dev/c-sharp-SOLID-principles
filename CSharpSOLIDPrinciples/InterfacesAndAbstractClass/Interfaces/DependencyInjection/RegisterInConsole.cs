using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Interfaces.DependencyInjection
{
    internal class RegisterInConsole : IRegister
    {
        public void RegisterInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
