using System;
namespace Task_2
{
    public class StaticClass
    {
        private static int[] Start(int n)
        {
            int[] Arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(-100, 101);
            }
            return Arr;
        }
        public static void Enter(int n)
        {
            int[] Arr = Start(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Count(n, Arr);
        }
        static void Count(int n, int[] Arr)
        {
            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if ((Arr[i] % 3 == 0) && (Arr[i + 1] % 3 != 0) || (Arr[i] % 3 != 0) && (Arr[i + 1] % 3 == 0))
                    sum++;
            }

            Console.WriteLine($"Количество пар элемента массива где только один элемент делится на 3 = {sum}");
            Console.ReadLine();
        }
    }
}
