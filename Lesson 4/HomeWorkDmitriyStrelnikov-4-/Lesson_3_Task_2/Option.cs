using System;
namespace Task_2
{
    public class Option
    {
        public static string Start()
        {
            Console.WriteLine("Выберите один из вариантов: \n1 - Рандомный ввод числа. \n2 - Ручной ввод числа.");
            int poz = int.Parse(Console.ReadLine());
            int sum = 0;
            switch (poz)
            {
                case 1:
                    sum = numberRandom();

                    break;
                case 2:
                    sum = numberRead();
                    break;
            }
            return $"Сумма нечетных положительных чисел ровна: {sum}";
        }

        private static int numberRandom()
        {
            int number;
            int sum = 0;
            Random r = new Random();
            do
            {
                number = r.Next(-10, 11);
                Console.WriteLine(number);
                if (number > 0 && (number % 2 != 0))
                {
                    sum += number;
                }

            } while (number != 0);
            return sum;
        }
        private static int numberRead()
        {
            int number;
            int sum = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out number);
                if (number > 0 && (number % 2 != 0))
                {
                    sum += number;
                }

            } while (number != 0);
            return sum;
        }
    }
}