using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExtensionMethods.Extensions.Types.String
{
    public static class StringExtensions
    {
        public static string ToUpper(this string value)
        {
            return value.ToUpper();
        }

        public static string ToUpperFirstLetter(this string value)
        {
            var splitValue = value.Split(" ");

            int count = splitValue.Count();

            string[] newValue = new string[count];

            for (int i = 0; i < count; i++)
            {
                char[] array = splitValue[i].ToCharArray();

                array[0] = char.ToUpper(array[0]);

                newValue[i] = new string(array);
            }

            return string.Join(" ", newValue);
        }
    }
}
