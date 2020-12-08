using System;

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Задание №2");
            Console.Write("Введите ваш рост (см.): ");
            float height = float.Parse(Console.ReadLine());
            height /= 100;
            Console.Write("Введите ваш вес: ");
            double weight = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);  //Вычесляем индекс массы тела

            double weightD = 0;

            if (BMI <= 15.99)
            {
                Console.WriteLine("Выраженный дефецит массы тела. Вам нужно набрать вес.");
                weightD = 20 * (height * height);
                weight = weightD - weight;
                Console.WriteLine("Вам нужно набрать вес на {0:f0} кг.", weight);
            }

            else if (BMI >= 16 && BMI <= 18.49)
            {
                Console.WriteLine("Недостаточная масса тела. Вам нужно набрать вес.");
                weightD = 20 * (height * height);
                weight = weightD - weight;
                Console.WriteLine("Вам нужно набрать вес на {0:f0} кг.", weight);

            }
                
            else if (BMI >= 18.50 && BMI <= 24.99)
            {
                Console.WriteLine("Масса тела в норме.");
            }
                
            else if (BMI >= 25 && BMI <= 29.99)
            {
                Console.WriteLine("Избыточная масса тела. Вам нужно сбросить вес.");
                weightD = 20 * (height * height);
                weight -= weightD;
                Console.WriteLine("Вам нужно сбросить вес на {0:f0} кг.", weight);
            }
                
            else if (BMI >= 30 && BMI <= 34.99)
            {
                Console.WriteLine("Ожирение первой степени. Вам нужно сбросить вес.");
                weightD = 20 * (height * height);
                weight -= weightD;
                Console.WriteLine("Вам нужно сбросить вес на {0:f0} кг.", weight);
            }
                
            else if (BMI >= 35 && BMI <= 39.99)
            {
                Console.WriteLine("Ожирение второй степени. Вам нужно сбросить вес.");
                weightD = 20 * (height * height);
                weight -= weightD;
                Console.WriteLine("Вам нужно сбросить вес на {0:f0} кг.", weight);
            }
                
            else
            {
                Console.WriteLine("Ожирение третьей степени. Вам нужно сбросить вес.");
                weightD = 20 * (height * height);
                weight -= weightD;
                Console.WriteLine("Вам нужно сбросить вес на {0:f0} кг.", weight);
            }    
                
        }
    }
}
