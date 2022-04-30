using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    internal class Product
    {
        public readonly string Name;
        public readonly int Price;

        public Product(string name, int price)
        {
            Name = name; 
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }

        public static bool operator !=(Product product1, Product product2)
        {
            return product1.Name != product2.Name && product1.Price != product2.Price;
        }

        public static bool operator ==(Product product1, Product product2)
        {
            return product1.Name == product2.Name && product1.Price == product2.Price;
        }
    }
}
