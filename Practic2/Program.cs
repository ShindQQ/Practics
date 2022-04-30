using System;
using System.Collections;
using System.Collections.Specialized;

namespace Practic2
{
    class Program
    {
        public class DescendedComparer : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                int ascendingResult = Comparer<string>.Default.Compare(x, y);

                return 0 - ascendingResult;
            }
        }

        public class IntensiveComparer : IEqualityComparer
        {
            readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            public int GetHashCode(object obj)
            {
                return obj.ToString().GetHashCode();
            }

            public new bool Equals(object x, object y)
            {
                return comparer.Compare(x, y) == 0;
            }
        }

        public static void DisplayContents(ICollection keyCollection, ICollection valueCollection, int dictionarySize)
        {
            string[] myKeys = new string[dictionarySize];
            int[] myValues = new int[dictionarySize];

            keyCollection.CopyTo(myKeys, 0);
            valueCollection.CopyTo(myValues, 0);

            for (int i = 0; i < dictionarySize; i++)
            {
                Console.WriteLine($"{myKeys[i]},  {myValues[i]}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            SortedList<string, int> sortedList = new SortedList<string, int> (/*new DescendedComparer()*/);

            sortedList.Add("A", 1);
            sortedList.Add("E", 1);
            sortedList.Add("C", 1);
            sortedList.Add("B", 1);
            sortedList.Add("D", 1);
            sortedList.Add("H", 1);
            sortedList.Add("G", 1);
            sortedList.Add("J", 1);
            sortedList.Add("F", 1);

            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("--------");

            var reversedSortedList = sortedList.Reverse();

            foreach (var item in reversedSortedList)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("--------");

            CustomerProductCollection<Customer, Product> cpCollection = new CustomerProductCollection<Customer, Product> ();

            Customer c = new Customer("A", "B", 1);
            Product p = new Product("A", 1);

            cpCollection.AddKeyValue(c, p);
            cpCollection.AddKeyValue(new Customer("C", "D", 2), new Product("C", 2));
            cpCollection.AddKeyValue(new Customer("E", "F", 3), p);
            cpCollection.AddKeyValue(new Customer("G", "H", 4), new Product("G", 4));

            cpCollection.AddValueByKey(c, new Product("B", 1));
            cpCollection.AddValueByKey(c, new Product("C", 1));
            cpCollection.AddValueByKey(c, new Product("D", 1));

            cpCollection.Print();

            Console.WriteLine("--------");

            foreach (var item in cpCollection[c])
            {
                item.Print();
            }

            Console.WriteLine("--------");

            foreach (var item in cpCollection[p])
            {
                item.Print();
            }

            ValueTypeCollection vtCollection = new ValueTypeCollection ();

            vtCollection.Add("Name1", new ValueType(1));
            vtCollection.Add("Name2", new ValueType(1.4));
            vtCollection.Add("Name3", new ValueType(2.4));
            vtCollection.Add("Name4", new ValueType(2));
            vtCollection.Add("Name5", new ValueType(3));

            Console.WriteLine("--------");

            vtCollection.Print();

            OrderedDictionary orderedDictionary = new OrderedDictionary(new IntensiveComparer());

            orderedDictionary.Add("A", 1);
            orderedDictionary.Add("E", 2);
            orderedDictionary.Add("C", 3);
            orderedDictionary.Add("B", 4);
            orderedDictionary.Add("D", 5);
            orderedDictionary.Add("H", 6);
            orderedDictionary.Add("G", 7);
            orderedDictionary.Add("J", 8);
            orderedDictionary.Add("F", 9);

            Console.WriteLine("--------");

            foreach (DictionaryEntry item in orderedDictionary)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            //ICollection keyCollection = orderedDictionary.Keys;
            //ICollection valueCollection = orderedDictionary.Values;

            //DisplayContents(keyCollection, valueCollection, orderedDictionary.Count);
        }
    }
}