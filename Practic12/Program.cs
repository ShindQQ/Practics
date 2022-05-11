using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practic12
{
    internal class Program
    {
        static Semaphore pool;
        static Mutex mutex = new Mutex(false, "Mutex");
        static string Function()
        {
            pool.WaitOne();
            pool.Release();

            mutex.WaitOne();
            mutex.ReleaseMutex();

            return new Random().Next().ToString();
        }
        
        static void Task1()
        {
            pool = new Semaphore(2, 4, "Semaphore");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                new Thread(del =>
                { sb.Append(Function()); }).Start(i);
            }

            using (Stream stream = File.Open(@"C:\Users\user\source\repos\Practics\Practic12\file.log", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(sb);
                }
            }
        }

        static void Task2()
        {
            Thread[] threads = new Thread[5];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread((del =>
                { sb.Append(Function()); }));
                threads[i].Name = i.ToString();
                threads[i].Start();
            }

            Console.WriteLine(sb);
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();

            Console.ReadKey();
        }
    }
}
