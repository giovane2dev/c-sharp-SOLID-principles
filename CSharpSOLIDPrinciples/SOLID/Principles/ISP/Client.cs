using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.ISP
{
    internal class Client : IPersistence, IMailMessage
    {
        public void SaveData()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }

        public void ValidateData()
        {
            throw new NotImplementedException();
        }
    }
}
