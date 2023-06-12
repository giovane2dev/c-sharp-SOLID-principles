using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.OCP
{
    public static class Extension
    {
        public static string ToLowerCase(this string value)
        {
            return value.ToLower();
        }
    }
}
