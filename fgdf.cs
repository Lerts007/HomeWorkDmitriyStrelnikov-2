using System;

namespace HomeWorkDmitriyStrelnikov2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            NewMethod(a, b, c);
        }

        private static void NewMethod(int a, int b, int c)
        {
            if (a < c && a < b)
                Console.WriteLine($"Минимальное число {a}");
            else if (b < c)
                Console.WriteLine($"Минимальное число {b}");
            else
                Console.WriteLine($"Минимальное число {c}");
        }
    }
}
