﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("a+b={0}", c);
            Console.ReadLine();
            /*
             Console.WriteLine方法类似于C语言的printf函数，
            */
            Console.WriteLine("{0,5:c}", 123.456);
            Console.ReadLine();
        }
    }
}
 