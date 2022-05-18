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
            Console.SetCursorPosition(0, 2);

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
            }

            Console.ReadKey(true);
        }
    }
}
