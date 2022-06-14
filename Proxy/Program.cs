using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHuman Bruce = new Operator();
            IHuman surrogate = new Surrogate(Bruce);

            surrogate.Request();

            Console.ReadKey();
        }
    }
}
