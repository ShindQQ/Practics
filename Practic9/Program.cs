using System.Collections;
using System.Collections.Specialized;


namespace Practic9
{
    class Program
    {
        static void FillMemory()
        {
            ByteArr[] barr = new ByteArr[10000];

            for (int i = 0; i < barr.Length; i++)
            {
                barr[i] = new ByteArr();

            }
        }

        static void CheckGeneration(int gcGeneration)
        {
            if (gcGeneration <= 2)
            {
                Console.WriteLine($"Generation: {gcGeneration}");
                Console.WriteLine($"Generaion was checked: {GC.CollectionCount(gcGeneration)} times");
                Console.WriteLine($"Generaion total memory: {GC.GetTotalMemory(false) / 1024}");
            }
        }

        static void Main(string[] args)
        {
            BigArrayDisposable barr = new BigArrayDisposable();

            barr.Dispose();

            FillMemory();

            CheckGeneration(0);
            CheckGeneration(1);
            CheckGeneration(2);
        }
    }
}