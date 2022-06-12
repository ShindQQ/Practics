using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class Prototype
    {
        public int ID { get; private set; }

        public Prototype(int id)
        {
            this.ID = id;
        }

        public abstract Prototype Clone();
    }
}
