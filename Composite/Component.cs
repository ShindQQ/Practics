using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);
    }
}
