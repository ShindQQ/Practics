using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Firm<T, Y> where T: Manager where Y : Worker
    {
        Dictionary<T, List<Y>> _firm = new Dictionary<T, List<Y>> ();

        public void AddKeyValue(T manager, Y worker)
        {
            _firm.Add(manager, new List<Y>());
            _firm[manager].Add(worker);
        }

        public void AddValueByKey(T manager, Y worker)
        {
            foreach (var firm_item in _firm)
            {
                if (firm_item.Key == manager)
                {
                    _firm[firm_item.Key].Add(worker);
                }
            }
        }

        public void Print()
        {
            foreach (var firm_item in _firm)
            {
                Console.WriteLine("Manager:");
                firm_item.Key.Print();

                foreach (var product in _firm[firm_item.Key])
                {
                    Console.WriteLine("Worker:");
                    product.Print();
                }
            }
        }

        public void Info(Person person)
        {
            bool check = false;

            if (person is T)
            {
                check = _firm.ContainsKey(person as T);
            }
            else if (person is Y)
            {
                foreach (var firm_item in _firm)
                {
                    if (person is Y)
                    {
                        check = _firm[firm_item.Key].Contains(person as Y);

                        if (check)
                        {
                            break;
                        }
                    }
                }
            }

            Type type = person.GetType();

            object[] attribute = type.GetCustomAttributes(false);

            if (person is T)
            {
                foreach (Attribute item in attribute)
                {
                    if (item is AccessLevelAttribute)
                    {
                        check = (item as AccessLevelAttribute).Check;

                    }
                }

                if (check == true)
                {
                    Console.WriteLine("Info");
                }
            }
            else if (person is Y)
            {
                foreach (Attribute item in attribute)
                {
                    if (item is AccessLevelAttribute)
                    {
                        check = (item as AccessLevelAttribute).Check;
                    }
                }

                if (check == false)
                {
                    Console.WriteLine("Info is blocked");
                }
            }
        }
    }
}
