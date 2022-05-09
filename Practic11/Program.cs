using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practic11
{
    internal class Program
    {
        static object block = new object();

        static void Function(int start, int end)
        {
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(block, ref acquiredLock);

                for (int i = start; i < end; i++)
                {
                    Console.WriteLine(i + "+" + Thread.CurrentThread.GetHashCode());
                }
            }
            finally
            {
                if (acquiredLock)
                {
                    Monitor.Exit(block);

                }
            }
        }

        static string ReadFile1()
        {
            string str;

            using (StreamReader reader = new StreamReader(@"C:\Users\user\source\repos\Practics\Practic11\file1.txt"))
            {
                str = reader.ReadToEnd();
            }

            return str;
        }

        static string ReadFile2()
        {
            string str;

            using (StreamReader reader = new StreamReader(@"C:\Users\user\source\repos\Practics\Practic11\file2.txt"))
            {
                str = reader.ReadToEnd();
            }

            return str;
        }

        static void WriteFile(string str1, string str2)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\user\source\repos\Practics\Practic11\file3.txt"))
            {
                writer.WriteLine(str1);
                writer.WriteLine(str2);
            }
        }

        static void Task2()
        {
            string res1 = null;
            string res2 = null;

            Thread thread1 = new Thread(del => { res1 = ReadFile1(); });
            thread1.Start();
            Thread thread2 = new Thread(del => { res2 = ReadFile2(); });
            thread2.Start();
            Thread thread3 = new Thread(del => WriteFile(res1, res2));
            thread3.Start();
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(del => Function(0,10));
            thread1.Start();
            //thread1.Join();
            Thread thread2 = new Thread(del => Function(10,20));
            thread2.Start();
            //thread2.Join();
            Thread thread3 = new Thread(del => Function(20,31));
            thread3.Start();
            //thread3.Join();

            Task2();

            Console.ReadKey();
        }
    }
}
