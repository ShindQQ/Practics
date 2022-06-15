using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man David = new Man();
            Robot ASIMO = new Robot();

            David.Clothes = "T-shirt, jeans";
            Console.WriteLine(David.Clothes);

            ASIMO.Backpack = David.Undress();

            David.Clothes = "Sportive shirt";
            Console.WriteLine(David.Clothes);

            David.Dress(ASIMO.Backpack);
            Console.WriteLine(David.Clothes);

            Console.ReadKey();
        }
    }
}
