using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9
{
    internal class ByteArr
    {
        private byte[] arr;

        public ByteArr()
        {
            arr = new byte[1024 * 50];
        }

        ~ByteArr()
        {
            Console.WriteLine("ByteArr destructor");
        }
    }
}
