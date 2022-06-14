using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Div : Command
    {
        public Div(ArithmeticUnit unit, int operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('/', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('*', Operand);
        }
    }
}
