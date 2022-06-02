using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("=========================================");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите номер запускаемой программы: ");
            string homeworkNumber = Console.ReadLine();
            Console.SetCursorPosition(0, 3);

            switch (homeworkNumber)
            {
                case "1_1":
                    lesson1_1.Lesson1_1();
                    break;
                case "1_2":
                    lesson1_2.Lesson1_2();
                    break;
                case "1_3":
                    lesson1_3.Lesson1_3();
                    break;
                case "2_1":
                    lesson2_1.DoublyLinkedList();
                    break;
                case "2_2":
                    lesson2_2.BinarySearch();
                    break;
                case "3_1":
                    lesson3_1.Benchmark();
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
