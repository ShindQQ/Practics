using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Operation()
        {
            Console.WriteLine(Name);
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
    }
}
