using FileReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace EvenNumbersSearch
{
    internal class Example
    {

        static void ExampleFunc()
        {
            Console.Write("Введите число =");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int summ  = SomeFunctions.Sum(4, 10);
            while (i <= n)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                }

                ++i;
            }
        }
    }
}