using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Cashier : IEnumerator
    {
        private Bank bank;
        private int current = -1;

        public Cashier(Bank enumerable)
        {
            bank = enumerable;
        }

        public bool MoveNext()
        {
            if (current < bank.Count -1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }

        public object Current
        {
            get { return bank[current]; }
        }
    }
}
