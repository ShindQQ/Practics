using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Surrogate : IHuman
    {
        IHuman Operator;

        public Surrogate(IHuman @operator)
        {
            Operator = @operator;
        }

        public void Request()
        {
            Operator.Request();
        }
    }
}
