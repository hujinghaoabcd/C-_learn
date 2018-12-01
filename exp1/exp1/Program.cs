using System;
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
             Console.WriteLine方法类似于C语言的printf函数，             可以采用“{N[,M][:格式化字符串]｝”的形式来格式化输出字符串，             其中的参数含义如下             花括号（{}）：用来在输出字符串中插入变量的值。              N：表示输出变量的序号，从0开始。             [,M][:格式化字符串]：可选项，其中M表示输出的变量所占的字符个数。             [:格式化字符串]：可选项，因为在向控制台输出时，常常需要指定输出字符串的格式
            */
            Console.WriteLine("{0,5:c}", 123.456);
            Console.ReadLine();
        }
    }
}
 