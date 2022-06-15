using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Shop : Colleague
    {
        public Shop(Mediator mediator) : base(mediator)
        {
        }

        public void SellKetchup()
        {
            string ketchup = "Ketchup";
            Console.WriteLine(GetType().Name + " sold " + ketchup);
        }
    }
}
