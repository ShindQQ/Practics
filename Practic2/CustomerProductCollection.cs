using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    internal class CustomerProductCollection<T, Y> where T : Customer where Y : Product
    {
        private Dictionary<T, List<Y>> cp = new Dictionary<T, List<Y>> ();
        private List<T> cList = new List<T> ();

        public void AddKeyValue(T customer, Y product)
        {
            cp.Add(customer, new List<Y> ());
            cp[customer].Add(product);
        }

        public void AddValueByKey(T customer, Y product)
        {
            foreach (var cp_item in cp)
            {
                if (cp_item.Key.Equals(customer))
                {
                    cp[cp_item.Key].Add(product);
                }
            }
        }

        public List<Y> this[T index]
        {
            get
            {
                return cp[index];
            }
        }
        public List<T> this[Y index]
        {
            get
            {
                foreach (var cp_item in cp)
                {
                    foreach (var product in cp[cp_item.Key])
                    {
                        if (product == index)
                        {
                            cList.Add(cp_item.Key);
                            break;
                        }
                    }
                }

                return cList;
            }
        }

        public void Print()
        {
            foreach (var cp_item in cp)
            {
                Console.WriteLine("Customer:");
                cp_item.Key.Print();

                foreach (var product in cp[cp_item.Key])
                {
                    Console.WriteLine("Product:");
                    product.Print();
                }
            }
        }
    }
}
