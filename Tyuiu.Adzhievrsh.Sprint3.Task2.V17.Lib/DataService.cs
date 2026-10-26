using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double term = Math.Pow(1.0 / (Math.Cos(k) + 2), 2);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}