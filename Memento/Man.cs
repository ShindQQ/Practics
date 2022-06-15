using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Man
    {
        public string Clothes { get; set; }

        public void Dress(Backpack backpack)
        {
            Clothes = backpack.Contents;
        }

        public Backpack Undress()
        {
            return new Backpack(Clothes);
        }
    }
}
