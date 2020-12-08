using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 3;
            string login;
            string password;
            do
            {
                i--;
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                i = NewMethod(i, login, password);

                if (i == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Да ты хакер!");
                    Console.ResetColor();
                }
                else
                    Console.WriteLine($"У вас осталось {i} попыток");


            } while (i >= 0);
        }

        private static int NewMethod(int i, string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                i = -1;

            }

            return i;
        }
    }
}
