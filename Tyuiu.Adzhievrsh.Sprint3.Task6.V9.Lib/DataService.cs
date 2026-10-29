using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task6.V9.Lib
{
    public class DataService : ISprint3Task6V9
    {

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                for (int divisor = 1; divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        sum += divisor;
                    }
                }
            }

            return sum;
        }
    }
}