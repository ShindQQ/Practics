using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Practic8
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "undefined";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public void Serialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream(@"C:\Users\user\source\repos\Practics\Practic8\person.xml", FileMode.OpenOrCreate))
            {
                XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode);

                xmlSerializer.Serialize(writer, this);

                Console.WriteLine("Object has been serialized");

                writer.Close();
            }
        }

        public void DeSerialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream(@"C:\Users\user\source\repos\Practics\Practic8\person.xml", FileMode.OpenOrCreate))
            {
                Person? person = xmlSerializer.Deserialize(fs) as Person;
                Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
            }
        }
    }
}
