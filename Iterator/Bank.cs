using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Bank : IEnumerable
    {
        List<Banknote> bankVault = new List<Banknote>
        {
            new Banknote(), new Banknote(),
            new Banknote(), new Banknote()
        };

        public Banknote this[int index]
        {
            get { return bankVault[index]; }
            set { bankVault.Insert(index, value); }
        }

        public int Count
        {
            get { return bankVault.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }
    }
}
