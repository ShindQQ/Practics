using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    internal class Customer
    {
        public readonly string Name;
        public readonly string FName;
        public readonly int Id;
        public Customer(string name, string fname, int ID)
        {
            Name = name;
            FName = fname;
            Id = ID;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, FName: {FName}, ID: {Id}");
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return customer1.Name != customer2.Name && customer1.FName != customer2.FName && customer1.Id != customer2.Id;
        }

        public static bool operator==(Customer customer1, Customer customer2)
        {
            return customer1.Name == customer2.Name && customer1.FName == customer2.FName && customer1.Id == customer2.Id;
        }
    }
}
