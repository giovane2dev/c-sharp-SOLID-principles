using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
    public interface IPersistence
    {
        public void ValidateData();
        public void SaveData();    
    }
}