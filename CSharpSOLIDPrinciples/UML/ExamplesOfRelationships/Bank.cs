using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.ExamplesOfRelationships
{
    public class Bank : IDisposable
    {
        public string Name { get; set; }

        // bank's accounts list
        public List<Account> accounts = new List<Account>();

        public void AddAccount()
        {
            accounts.Add(new Account(this));
        }

        public void Dispose()
        {
            // note: if agregation case, not implements the dispose method
            foreach (var account in accounts)
            {
               account.Dispose();
            }
        }
    }
}
