using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public int PassportID { get; set; }

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

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, FName: {FName}, PassportID: {PassportID}");
        }

        public virtual bool Equals(Person person)
        {
            return Name.Equals(person.Name) && FName.Equals(person.FName) && PassportID.Equals(person.PassportID);
        }

        public virtual void Copy(Person person)
        {
            this.Name = person.Name;
            this.FName = person.FName;
            this.PassportID = person.PassportID;
        }
    }
}
