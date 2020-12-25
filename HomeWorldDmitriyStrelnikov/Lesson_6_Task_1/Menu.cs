using System;
namespace Lesson_6_Task_1
{
    public class Menu
    {
        public Menu()
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("Выберите функцию:" +
                "\n1. - 5 * x\u00B2" +
                "\n2 - 2 * Sin(x)" +
                "\n3 - x\u00B2 * Tg(x)" +
                "\n4 - для выхода из програмы.");
                Plot diapozon;

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        diapozon = new Plot();
                        diapozon.Enter(diapozon.f);
                        break;

                    case 2:
                        diapozon = new Plot();
                        diapozon.Enter(diapozon.g);
                        break;

                    case 3:
                        diapozon = new Plot();
                        diapozon.Enter(diapozon.y);
                        break;

                    case 4:
                        a = false;
                        break;
                }

            }
            
        }
    }
}
