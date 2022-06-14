using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context()
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var experssion = new NonTerminalExpression();
            experssion.Interpret(context);

            Console.WriteLine(context.Result);

            Console.ReadKey();
        }
    }
}
