﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flag = new UkraineFlag();
            flag.Draw();

            Console.ReadKey();
        }
    }
}
