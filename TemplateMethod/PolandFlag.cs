using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class PolandFlag : TwoColorFlag
    {
        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
