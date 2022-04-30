using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    public struct ValueType
    {
        public int _int = default;
        public double _double = default;

        public ValueType(int i)
        {
            _int = i;
        }
        public ValueType(double d)
        {
            _double = d;
        }
        public override int GetHashCode()
        {
            return Tuple.Create(_int, _double).GetHashCode();
        }

        public void Print()
        {
            if (_int.Equals(default))
            {
                Console.WriteLine($"{_double}");
            }
            else
            {
                Console.WriteLine($"{_int}");
            }
        }
    }

    internal class ValueTypeCollection
    {
        private Dictionary<string, ValueType> vt = new Dictionary<string, ValueType> ();

        public void Add(string name, ValueType price)
        {
            vt.Add(name, price);
        }

        public void Print()
        {
            foreach (var item in vt)
            {
                Console.Write($"Name: {item.Key}, Price: ");
                item.Value.Print();
            }
        }
    }
}
