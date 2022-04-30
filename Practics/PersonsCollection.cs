using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practic1
{
    internal class PersonsCollection<T> : IEnumerable where T : Person
    {
        private List<T> people = new List<T>();

        public int Add(T person)
        {
            Worker worker = new Worker();
            Pensioneer pensioneer = new Pensioneer();
            bool check = false;
            Type t = person.GetType();

            if (person != null)
            {
                if (people.Count() == 0)
                {
                    people.Add(person);
                }

                if (t == typeof(Student))
                {
                    people.Add(person);

                    return people.IndexOf(person);
                }
                else if (t == typeof(Worker))
                {
                    foreach (T item in people)
                    {
                        if (item is Worker && !item.Equals(person))
                        {
                            worker.Copy(item);
                            check = true;
                        }
                    }

                    if (check)
                    {
                        people.Insert(people.IndexOf(worker as T) + 1, person);
                    }
                    else if (WorkersAmmount() == 0)
                    {
                        people.Insert(0, person);
                    }

                    check = false;

                    return people.IndexOf(person);
                }
                else if (t == typeof(Pensioneer))
                {
                    foreach (Person item in people)
                    {
                        if (item is Pensioneer && !item.Equals(person))
                        {
                            pensioneer.Copy(item);
                            check = true;
                        }
                    }

                    if (check)
                    {
                        people.Insert(people.IndexOf(pensioneer as T) + 1, person);
                    }
                    else if(PensioneersAmmount() == 0)
                    {
                        people.Insert(0, person);
                    }

                    check = false;

                    return people.IndexOf(person);
                }
            }

            return -1;
        }

        private int WorkersAmmount()
        {
            int counter = 0;

            foreach (Person item in people)
            {
                if (item is Worker)
                {
                    counter++;
                }
            }

            return counter;
        }

        private int PensioneersAmmount()
        {
            int counter = 0;

            foreach (Person item in people)
            {
                if (item is Pensioneer)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void RemoveFirst()
        {
            people.RemoveAt(0);
        }

        public void RemoveItem(T person)
        {
            people.Remove(person);
        }

        public (bool, int) Contains(T person)
        {
            return (people.Contains(person), people.IndexOf(person));
        }

        public (Person, int) ReturnLast()
        {
            return (people.ElementAt(people.Count -1), people.Count);
        }

        public void Clear()
        {
            people.Clear();
        }


        private int position = -1;

        private void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            while (true)
            {
                if (position < people.Count - 1)
                {
                    position++;
                    yield return people.ElementAt(position);
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        public void Print()
        {
            foreach(var item in people)
            {
                item.Print();
            }
        }
    }
}
