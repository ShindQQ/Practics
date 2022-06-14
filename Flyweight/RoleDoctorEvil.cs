using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class RoleDoctorEvil : Flyweight
    {
        Flyweight Flyweight;

        public RoleDoctorEvil(Flyweight flyweight)
        {
            Flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            Flyweight.Greeting(speech);
        }
    }
}
