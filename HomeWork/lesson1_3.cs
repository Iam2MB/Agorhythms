using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class lesson1_3
    {
        public static void Lesson1_3()
        {
            Console.Write("Введите значение: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Число Фибоначчи для заданного значения равно: {Fib(num)}");
        }

        private static int Fib(int numFib)
        {
            if (numFib == 0 || numFib == 1)
            {
                return numFib;
            }
            else
            {
                return Fib(numFib - 1) + Fib(numFib - 2);
            }
        }
    }
}
