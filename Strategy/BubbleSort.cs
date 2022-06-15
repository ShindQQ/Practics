using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class BubbleSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("Bubble Sort");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    }
                }
            }
        }
    }
}
