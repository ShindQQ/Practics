using Practic7;
using System.Reflection;

namespace Practiс7
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Firm<Manager, Worker> firm = new Firm<Manager, Worker> ();
            Manager manager = new Manager();
            Worker worker = new Worker();

            firm.AddKeyValue(manager, worker);

            firm.Info(manager);
            firm.Info(worker);

        }
    }
}