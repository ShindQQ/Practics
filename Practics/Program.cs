using System;
using System.Collections;

namespace Practic1
{
    class Program
    {
        static IEnumerator<int> AddTask(int[] arr)
        {
            for (int i = 1; i < arr.Length; i += 2)
            {
                yield return (int)Math.Pow(arr[i], 2);
            }
            yield break;
        }

        public class MonthsCollection : IEnumerable
        {
            private Dictionary<string, int> months = new Dictionary<string, int>();

            public MonthsCollection()
            {
                months.Add("January", 31);
                months.Add("February28", 28);
                months.Add("February29", 29);
                months.Add("March", 31);
                months.Add("April", 30);
                months.Add("May", 31);
                months.Add("June", 30);
                months.Add("July", 31);
                months.Add("August", 31);
                months.Add("September", 30);
                months.Add("October", 31);
                months.Add("November", 30);
                months.Add("December", 31);
            }

            private int position = -1;

            private void Reset()
            {
                position = -1;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                while(true)
                {
                    if (position < months.Count - 1)
                    {
                        position++;
                        yield return (months.ElementAt(position).Key, months.ElementAt(position).Value);
                    }
                    else
                    {
                        Reset();
                        yield break;
                    }
                }
            }

            public IEnumerable GetMonth(int day)
            {
                foreach (var key in months.Keys)
                {
                    if (months[key] == day)
                    {
                        yield return (key, months[key]);
                    }
                }
                yield break;
            }
        }
                
        static void Main(string[] args)
        {
            IEnumerator<int> arr = AddTask(new int[] { 1, 2, 3, 4, 5, 6 });

            while (arr.MoveNext())
            {
                Console.WriteLine(arr.Current);
            }

            Console.WriteLine("--------");

            MonthsCollection months = new MonthsCollection();

            foreach (var item in months)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            foreach (var item in months.GetMonth(31))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            PersonsCollection personsCollection = new PersonsCollection();

            personsCollection.Add(new Pensioneer("Ivan", "Ivanovich", 1));
            personsCollection.Add(new Pensioneer("Ivan", "Ivanovich", 1));
            personsCollection.Add(new Pensioneer("Ivan", "Ivanovich", 2));
            personsCollection.Add(new Pensioneer("Ivan", "Ivanovich", 3));
            personsCollection.Add(new Pensioneer("Ivan", "Ivanovich", 4));
            personsCollection.Add(new Worker("Ivan", "Ivanovich", 6));
            personsCollection.Add(new Worker("Ivan", "Ivanovich", 7));
            personsCollection.Add(new Worker("Ivan", "Ivanovich", 8));
            personsCollection.Add(new Worker("Ivan", "Ivanovich", 9));
            personsCollection.Add(new Student("Ivan", "Ivanovich", 10));
            personsCollection.Add(new Student("Ivan", "Ivanovich", 12));
            personsCollection.Add(new Student("Ivan", "Ivanovich", 13));
            personsCollection.Add(new Student("Ivan", "Ivanovich", 14));
            personsCollection.Add(new Student("Ivan", "Ivanovich", 15));

            personsCollection.Print();
        }
    }
}