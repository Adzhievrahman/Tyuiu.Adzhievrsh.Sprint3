using System;
using Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Task #3 | Вариант 10";

            Console.WriteLine("****************************************************");
            Console.WriteLine("*  Спринт #3                                       *");
            Console.WriteLine("*  Task #3                                         *");
            Console.WriteLine("*  Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            string value = "gdfppf vfpppt p";
            string result = ds.DeleteCharInString(value);

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}