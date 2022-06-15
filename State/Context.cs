using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        public State state { get; set; }

        public Context(State state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
