using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class PepsiWater : AbstractWater
    {
        public override void Water()
        {
            Console.WriteLine("PepsiWater");
        }

        public override string ToString()
        {
            return "PepsiWater";
        }
    }
}
