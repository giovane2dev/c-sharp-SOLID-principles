using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Product : IProduct
    {
        public void AddProduct(string name)
        {
            Console.WriteLine(name);
        }
    }
}
