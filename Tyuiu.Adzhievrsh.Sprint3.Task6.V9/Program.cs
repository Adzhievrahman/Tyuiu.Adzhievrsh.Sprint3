using System;
using Tyuiu.Adzhievrsh.Sprint3.Task6.V9.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #6 | Вариант 9";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #6                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 30;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Общее количество делителей = {result}");

            Console.ReadKey();
        }
    }
}