using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Foreman
    {
        Builder builder;

        public Foreman(Builder builder)
        {
            this.builder = builder;
        }

        public void Constuct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
