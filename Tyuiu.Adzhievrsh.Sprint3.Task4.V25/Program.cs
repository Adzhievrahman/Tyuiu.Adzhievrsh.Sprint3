using System;
using Tyuiu.Adzhievrsh.Sprint3.Task4.V25.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #4 | Вариант 25";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #4                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            double result = ds.Calculate();

            Console.WriteLine($"Сумма значений функции = {result}");

            Console.ReadKey();
        }
    }
}