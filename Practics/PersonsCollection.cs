using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practic1
{
    internal class PersonsCollection : IEnumerable
    {
        public List<Person> people = new List<Person>();
        private Worker worker = new Worker();
        private Pensioneer pensioneer = new Pensioneer();
        private bool check = false;

        public int Add(Person person)
        {
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
                    foreach (Person item in people)
                    {
                        if (item is Worker && !item.Equals(person))
                        {
                            worker.Copy(item);
                            check = true;
                        }
                    }

                    if (check)
                    {
                        people.Insert(people.IndexOf(worker) + 1, person);
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
                        people.Insert(people.IndexOf(pensioneer) + 1, person);
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

        public void RemoveItem(Person person)
        {
            people.Remove(person);
        }

        public (bool, int) Contains(Person person)
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
