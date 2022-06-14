using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Command
    {
        protected ArithmeticUnit Unit;
        protected int Operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
