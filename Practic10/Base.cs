using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10
{
    internal class Base
    {
        public void DoWork() // template method
        {
            PreDoWork();
            CoreDoWork();
        }

        protected void PreDoWork()
        {
            Console.WriteLine(0);
        }

        protected virtual void CoreDoWork()
        {
            Console.WriteLine(1);
        }
    }
}
