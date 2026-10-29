using System;
using Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #5 | Вариант 20";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #5                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            double result = ds.Calculate();

            Console.WriteLine($"Результат вычисления y = {result}");

            Console.ReadKey();
        }
    }
}