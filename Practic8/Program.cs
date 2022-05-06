using System.Collections;
using System.Collections.Specialized;


namespace Practic8
{
   

    class Program
    {
        
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 37);

            person.Serialize();
            person.DeSerialize();
        }
    }
}