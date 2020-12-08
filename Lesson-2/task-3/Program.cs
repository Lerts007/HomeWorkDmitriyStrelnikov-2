using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Стрельников
             * Задание №3
             * С клавиатуры вводятся числа, пока не будет введен 0. 
             * Подсчитать сумму всех нечетных положительных чисел.
             */
            int number;
            int sum = 0;
            Console.WriteLine("Введите целое число: ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Введите целое число!");
                }
                if (number >= 0 && (number % 2 != 0))
                {
                    sum += number;
                    Console.WriteLine($"Сумма нечетных положительных чисел = {sum}");
                }
            } while (number != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел = {sum}");
        }
    }
}
