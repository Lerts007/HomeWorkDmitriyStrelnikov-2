using System;

namespace task_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание №2");

            Console.Write("Введите целое число: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
            }
            count(number);
        }

        private static void count(int a)
        {
            int i = 1;
            int number = a;
            while (a > 1)
            {
                a /= 10;
                i++;
            }
            Console.WriteLine($"Количество цифр в числе {number} = {i}");
        }
    }
}
