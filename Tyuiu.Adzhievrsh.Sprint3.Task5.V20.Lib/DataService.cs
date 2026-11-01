using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double Calculate()
        {
            return GetSumSumSeries(5, 1, 1, 3, 6);
        }

        public double GetSumSumSeries(
            int x,
            int startValue1,
            int startValue2,
            int stopValue1,
            int stopValue2)
        {
            double sum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Pow((double)x / Math.Sin(x), k);
                }
            }

            return Math.Round(sum, 3);
        }
    }
}