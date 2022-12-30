// task 61

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paskal
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int i, n, c;
            Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
            string s = Console.ReadLine();
            n = Convert.ToInt32(s);

            for (i = 0; i < n; i++)
            {
                for (c = 0; c <= (n - i); c++)
                {
                    Console.Write(" "); 
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" ");
                    Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public static float factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;

        }
    }
}