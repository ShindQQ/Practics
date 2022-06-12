using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class CocaColaWater : AbstractWater
    {
        public override void Water()
        {
            Console.WriteLine("CocaColaWater");
        }

        public override string ToString()
        {
            return "CocaColaWater";
        }
    }
}
