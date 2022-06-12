using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Constuct();

            House house = builder.GetResult();

            Console.ReadKey();
        }
    }
}
