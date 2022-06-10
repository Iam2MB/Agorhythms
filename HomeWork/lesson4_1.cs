using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork
{
    internal class lesson4_1
    {
        public static void StringSearchTest()
        {
            Random random = new Random();
            HashSet<int> hashset = new HashSet<int>();
            int[] array = new int[100000];
            int stringsCount = array.Length;

            for (int i = 0; i < stringsCount; i++)
            {
                int k = random.Next(1, stringsCount);
                hashset.Add(k);
                array[i] = k;
            }

            Console.Write($"Введите значение до {stringsCount}: ");
            int number = int.Parse(Console.ReadLine());
            Stopwatch timeSpent = new Stopwatch();

            timeSpent.Start();
            int temp = 0;
            foreach (var item in array)
            {
                if (item.Equals(number))
                {
                    temp++;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("\nТакого значения нет в array");
            }
            timeSpent.Stop();
            Console.WriteLine($"Time Spent of Array:\t{timeSpent.Elapsed}");

            timeSpent.Restart();
            temp = 0;
            foreach (var item in hashset)
            {
                if (item.Equals(number))
                {
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("\nТакого значения нет в hashset");
            }
            timeSpent.Stop();
            Console.Write($"Time spent of HashSet:\t{timeSpent.Elapsed}");

            Console.ReadLine();

        }
    }
}
