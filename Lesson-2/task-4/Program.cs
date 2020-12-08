using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Стрельников
             * Задание №4
             * Реализовать метод проверки логина и пароля. На вход метода 
             * подается логин и пароль. На выходе истина, если прошел 
             * авторизацию, и ложь, если не прошел (Логин: root, Password: 
             * GeekBrains). Используя метод проверки логина и пароля, написать 
             * программу: пользователь вводит логин и пароль, программа 
             * пропускает его дальше или не пропускает. С помощью цикла do while 
             * ограничить ввод пароля тремя попытками.
             */

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
