using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Component
    {
        public Component component { protected get; set; }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
