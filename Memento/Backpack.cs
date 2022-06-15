using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Backpack
    {
        public string Contents
        {
            get;
            private set;
        }

        public Backpack(string contents)
        {
            Contents = contents;
        }
    }
}
