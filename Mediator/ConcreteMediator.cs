using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Farmer)
            {
                Cannery.MakeKetchup();
            }
            else if (colleague == Cannery)
            {
                Shop.SellKetchup();
            }
        }
    }
}
