using System;
using Tyuiu.Adzhievrsh.Sprint3.Task1.V18.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #1 | Вариант 18";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #1                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Вычислить сумму ряда с помощью цикла while.");
            Console.WriteLine("S = сумма sin(i) * (1/4)^2, i от 1 до 15.");
            Console.WriteLine();

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double result = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"Сумма ряда S = {result}");

            Console.ReadKey();
        }
    }
}