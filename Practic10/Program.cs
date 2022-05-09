using System.Collections;
using System.Collections.Specialized;


namespace Practic10
{
    class Program
    {
        static void Main(string[] args)
        {
            Base instance = new Derived();
            instance.DoWork();

            Base instance1 = new Base();
            instance1.DoWork();
        }
    }
}