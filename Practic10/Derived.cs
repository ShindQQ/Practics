using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10
{
    internal class Derived : Base
    {
        protected override void CoreDoWork()
        {
            Console.WriteLine(2);
        }
    }
}
