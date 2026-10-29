using System;
using Tyuiu.Adzhievrsh.Sprint3.Task7.V28.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #7 | Вариант 28";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #7                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"x = {x,3} | F(x) = {result[i],8:F2}");
            }

            Console.ReadKey();
        }
    }
}