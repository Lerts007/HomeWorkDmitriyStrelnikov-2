using System;
namespace Lesson_6_Task_1
{
    public class Load
    {
        double[] ArrayLoad;

        public Load(double[] ArrayLoad)
        {
            this.ArrayLoad = ArrayLoad;
        }

        public void Output(out double ResMin)
        {
            ResMin = ArrayLoad[0];
            for (int i = 1; i < ArrayLoad.Length; i++)
            {
                if (ArrayLoad[i] < ResMin) ResMin = ArrayLoad[i];
            }
        }
    }
}
