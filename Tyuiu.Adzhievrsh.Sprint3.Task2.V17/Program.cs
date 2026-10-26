using System;
using Tyuiu.Adzhievrsh.Sprint3.Task2.V17.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #2 | Вариант 17";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #2                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            double result = ds.GetSumSeries(1, 10);

            Console.WriteLine($"Сумма ряда S = {result}");
            Console.ReadKey();
        }
    }
}