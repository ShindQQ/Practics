using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    internal class AccessLevelAttribute : Attribute
    {
        public readonly bool Check;

        public AccessLevelAttribute(bool check)
        {
            Check = check;
        }
    }
}
