using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActorMikeMyers mike = new ActorMikeMyers();

            RoleAustinPowers austin = new RoleAustinPowers(mike);
            austin.Greeting("Hello! I am Austin Powers!");
            
            RoleDoctorEvil dv = new RoleDoctorEvil(mike);
            dv.Greeting("Hello! I am Dr. Evil!");

            Console.ReadKey();
        }
    }
}
