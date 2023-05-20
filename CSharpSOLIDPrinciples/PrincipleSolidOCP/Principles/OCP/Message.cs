using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.OCP
{
    public class Message
    {
        public Message()
        {
            
        }

        public virtual void Create(string shortMessage)
        {
            Console.WriteLine(shortMessage);
        }
    }
}
