using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Cannery : Colleague
    {
        public Cannery(Mediator mediator) : base(mediator)
        {
        }

        public void MakeKetchup ()
        {
            string ketchup = "Ketchup";
            Console.WriteLine(GetType().Name + " produced " + ketchup);
            mediator.Send(ketchup, this);
        }
    }
}
