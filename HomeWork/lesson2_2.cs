using System;
using System.Collections.Generic;

namespace HomeWork
{
    internal class lesson2_2
    {
        public static void BinarySearch()
        {
            List<int> list = new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int low = 0;
            int high = list.Count - 1;
            int mid = 0;
            int findThis = 0;
            int k = 0; //коэффициент сложности

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            while (findThis < list[0] || findThis > list[list.Count - 1]) //Ввод числа из списка
            {
                try
                {
                    Console.Write($"Введите число от {list[0]} до {list[list.Count-1]}: ");
                    findThis = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
            }
            while (list[mid] != findThis) //Бинарный поиск позиции числа в списке
            {
                mid = (low + high) / 2;
                if (findThis < list[mid])
                {
                    high = mid - 1;
                }
                else if (findThis > list[mid])
                {
                    low = mid + 1;
                }
                k++;
            }

            Console.WriteLine($"Позиция числа {findThis} - {mid}");
            Console.WriteLine($"Коэффициент сложности поиска равен: {k}");
        }
    }
}
