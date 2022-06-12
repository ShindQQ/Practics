using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House GetResult();
    }
}
