using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class InsertionSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                }
            }
        }
    }
}
