using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.DIP
{
    public class RecoveryPassword
    {
        IDataBaseConnection dataBaseConnection;

        public RecoveryPassword(IDataBaseConnection dataBaseConnection)
        {
            this.dataBaseConnection = dataBaseConnection;
        }
    }
}
