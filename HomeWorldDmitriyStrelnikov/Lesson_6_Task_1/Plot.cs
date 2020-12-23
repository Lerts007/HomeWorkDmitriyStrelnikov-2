using System;
namespace Lesson_6_Task_1
{
    public delegate double Function(double arg);

    public class Plot
    {
        public Plot()
        {
        }
        public double f(double x) { return 2 * x * x; }

        public double g(double x) { return 2 * Math.Sin(x); }

        public void Enter(Function fanc, int min, int max)
        {
            for (int x = min; x <= max; x++)
            {
                Console.WriteLine($"{x,3} | {fanc(x): 0.00}");
            }
            Console.WriteLine();
        }
    }
}
