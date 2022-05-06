using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    [AccessLevelAttribute(false)]
    internal class Worker : Person
    {
        private string Speciality;

        public Worker() : base()
        {
            Speciality = "undefined";
        }

        public Worker(string name, string fname, int ID, string speciality) : base(name, fname, ID)
        {
            Speciality = speciality;
        }

        public override void Print()
        {
            base.Print();

            Console.Write($", Speciality: {Speciality}");
        }

        public override bool Equals(Person person)
        {
            return base.Equals(person) && (person as Worker).Speciality == Speciality;
        }

        public override void Copy(Person person)
        {
            this.Name = person.Name;
            this.FName = person.FName;
            this.PassportID = person.PassportID;
            this.Speciality = (person as Worker).Speciality;
        }
    }
}
