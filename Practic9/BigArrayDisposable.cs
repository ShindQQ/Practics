using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9
{
    internal class BigArrayDisposable : IDisposable
    {
        private int[] arr;
        private bool disposed = false;

        public BigArrayDisposable()
        {
            arr = new int[100000];
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose");
                }
                disposed = true;
            }
        }

        ~BigArrayDisposable()
        {
            Dispose(disposing: false);
        }
    }
}
