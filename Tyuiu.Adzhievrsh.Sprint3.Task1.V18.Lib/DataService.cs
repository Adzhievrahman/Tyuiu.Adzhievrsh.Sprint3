using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sumSeries += Math.Sin(i) * Math.Pow(1.0 / 4, 2);
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}