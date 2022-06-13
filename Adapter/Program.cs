using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();

            Target target1 = new Adapter1();
            target.Request();

            Console.ReadKey();
        }
    }
}
