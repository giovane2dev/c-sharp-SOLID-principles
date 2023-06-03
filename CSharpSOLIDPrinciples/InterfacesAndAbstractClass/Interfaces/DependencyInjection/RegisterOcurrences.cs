using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Interfaces.DependencyInjection
{
    public class RegisterOcurrences
    {
        private readonly IRegister _register;

        public RegisterOcurrences(IRegister register)
        {
            _register = register;
        }

        public void Register(string message)
        {
            _register.RegisterInfo(message);
        }
    }
}
