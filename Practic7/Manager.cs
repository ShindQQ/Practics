using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    [AccessLevelAttribute(true)]
    internal class Manager : Person
    {
        private string Section;

        public Manager() : base()
        {
            Section = "undefined";
        }

        public Manager(string name, string fname, int ID, string section) : base(name, fname, ID)
        {
            Section = section;
        }

        public override void Print()
        {
            base.Print();

            Console.Write($", Section: {Section}");
        }

        public override bool Equals(Person person)
        {
            return base.Equals(person) && (person as Manager).Section == Section;
        }

        public override void Copy(Person person)
        {
            this.Name = person.Name;
            this.FName = person.FName;
            this.PassportID = person.PassportID;
            this.Section = (person as Manager).Section;
        }
    }
}
