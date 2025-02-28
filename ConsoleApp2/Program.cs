using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(13 / 5);    // output: 2
            Console.WriteLine(-13 / 5);   // output: -2
            Console.WriteLine(13 / -5);   // output: -2
            Console.WriteLine(-13 / -5);  // output: 2

            Console.WriteLine(13 / 5.0);       // output: 2.6

            int a = 13;
            int b = 5;
            Console.WriteLine((double)a / b);  // output: 2.6

            Console.WriteLine(5 % 4);   // output: 1
            Console.WriteLine(5 % -4);  // output: 1
            Console.WriteLine(-5 % 4);  // output: -1
            Console.WriteLine(-5 % -4); // output: -1
        }
    }
}
