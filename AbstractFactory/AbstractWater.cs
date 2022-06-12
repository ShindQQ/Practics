using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractWater
    {
        public virtual void Water()
        {
            Console.WriteLine("AbstractWater");
        }
    }
}
