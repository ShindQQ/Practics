using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal abstract class Person
    {
        protected string Name { get; set; }
        protected string FName { get; set; }
        protected int PassportID { get; set; }

        public Person()
        {
            Name = "undefined";
            FName = "undefined";
            PassportID = 0;
        }

        public Person(string name, string fname, int ID)
        {
            Name = name;
            FName = fname;
            PassportID = ID;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, FName: {FName}, PassportID: {PassportID}");
        }

        public bool Equals(Person person)
        {
            return Name.Equals(person.Name) && FName.Equals(person.FName) && PassportID.Equals(person.PassportID);
        }

        public void Copy(Person person)
        {
            this.Name = person.Name;
            this.FName = person.FName;
            this.PassportID = person.PassportID;
        }
    }
}
