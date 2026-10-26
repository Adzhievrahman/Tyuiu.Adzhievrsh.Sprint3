using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                double denominator = Math.Pow(Math.Sin(1), -7);
                double term = Math.Pow(k / denominator, -2);

                multiplySeries *= term;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}