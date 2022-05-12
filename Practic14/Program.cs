using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14
{
    internal class Program
    {
        static void Task1()
        {
            int[] array = new int[1000000];

            Parallel.For(0, array.Length, i => array[i] = new Random().Next());

            ParallelQuery<int> odds = from int element in array.AsParallel<int>() where element % 2 == 1 select element;

            foreach (var item in odds)
            {
                Console.Write($"{item} ");
            }
        }

        static void Task21()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("- ");
            }
        }

        static void Task22()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("+ ");
            }
        }

        static void Main(string[] args)
        {
            //Task1();

            Task task1 = new Task(Task21);
            Task task2 = new Task(Task22);

            task1.Start();
            task2.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("_");
            }

            Task.WaitAny(task1, task2);

            Console.ReadKey();
        }
    }
}
