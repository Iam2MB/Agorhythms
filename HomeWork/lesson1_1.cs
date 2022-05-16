using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class lesson1_1
    {
        public static void Lesson1_1()
        {
            int number = int.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;

            while ( i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else 
            {
                Console.WriteLine("Не простое");
            }
        }
    }
}
