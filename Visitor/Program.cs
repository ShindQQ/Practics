using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Village village = new Village();

            village.Add(new BoysHouse());
            village.Add(new GirlsHouse());
            village.Accept(new Santa());


            Console.ReadKey();
        }
    }
}
