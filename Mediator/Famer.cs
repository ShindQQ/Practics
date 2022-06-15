using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Farmer : Colleague
    {
        public Farmer(Mediator mediator) : base(mediator)
        {
        }

        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(GetType().Name + " raised " + tomato);
            mediator.Send(tomato, this);
        }
    }
}
