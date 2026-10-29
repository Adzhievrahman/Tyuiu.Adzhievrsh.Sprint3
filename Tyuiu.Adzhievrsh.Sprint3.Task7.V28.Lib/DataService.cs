using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double denominator = x + 2.5;

                if (denominator == 0)
                {
                    result[i] = 0;
                }
                else
                {
                    double y = Math.Cos(2 * x)
                               + Math.Sin(x) / denominator
                               + 2 * x;

                    result[i] = Math.Round(y, 2);
                }
            }

            return result;
        }
    }
}