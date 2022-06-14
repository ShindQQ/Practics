using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Operator : IHuman
    {
        public void Request()
        {
            Console.WriteLine("Operator");
        }
    }
}
