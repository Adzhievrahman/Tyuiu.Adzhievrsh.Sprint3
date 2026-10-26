using System;
using Tyuiu.Adzhievrsh.Sprint3.Task0.V2.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #0 | Вариант 2";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #0                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            double result = ds.GetMultiplySeries(1, 9);

            Console.WriteLine($"Произведение ряда p = {result}");
            Console.ReadKey();
        }
    }
}