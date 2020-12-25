using System;
namespace Lesson_6_Task_1
{
    public delegate double Function(double x);

    public class Plot
    {
        int min;
        int max;

        public Plot()
        {
            int min, max;
            Console.Write("Введите длину отрезка." +
                "\nМинимальное значение min = ");
            while(!int.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Введите целое число!");
                Console.Write("Минимальное значение min = ");
            }
            this.min = min;

            Console.Write("Максимальное значение max = ");
            while (!int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Введите целое число!");
                Console.Write("Максимальное значение max = ");
            }
            this.max = max;
        }

        public double f(double x) { return 5 * x * x; }

        public double g(double x) { return 2 * Math.Sin(x); }

        public double y(double x) { return x * x * Math.Tan(x); }

        public void Enter(Function fanc)
        {
            for (int x = min; x <= max; x++)
            {
                Console.WriteLine($"{x,3} | {fanc(x): 0.00}");
            }
            Console.WriteLine();
        }
    }
}
