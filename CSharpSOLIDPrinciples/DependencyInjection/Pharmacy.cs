using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Pharmacy
    {
        private readonly IProduct _iproduct;

        public Pharmacy(IProduct iproduct)
        {
            this._iproduct = iproduct;
        }

        public void AddNewPharmacyProduct(string name)
        {
            this._iproduct.AddProduct(name);
        }
    }
}
