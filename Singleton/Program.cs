using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            instance1.SingeletonOperation();
            string singletonData = instance1.GetSingletonData();
            Console.WriteLine(singletonData);

            Console.ReadKey();
        }
    }
}
