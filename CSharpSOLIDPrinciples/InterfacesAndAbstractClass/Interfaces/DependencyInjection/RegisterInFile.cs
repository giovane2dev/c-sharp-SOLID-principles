using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClass.Interfaces.DependencyInjection
{
    internal class RegisterInFile : IRegister
    {
        private readonly string _filePath;

        public RegisterInFile(string filePath)
        {
            _filePath = filePath;
        }
        public void RegisterInfo(string message)
        {
            Log(message);
        }

        private void Log(object message)
        {
            using (var stream = new StreamWriter(_filePath, true))
            {
                stream.WriteLine(message);
            }
        }
    }
}
