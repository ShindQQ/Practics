using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class RoleAustinPowers : Flyweight
    {
        Flyweight Flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            Flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            Flyweight.Greeting(speech);
        }
    }
}
