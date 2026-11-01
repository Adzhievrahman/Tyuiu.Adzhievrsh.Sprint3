using System;
using Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Аджиев Р.Ш.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема #3.3 Оператор цикла foreach                                        *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: удалить из строки все буквы p                                  *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string value = "gdfppf vfpppt p";

            Console.WriteLine("Исходная строка: " + value);

            string result = ds.DeleteCharInString(value);

            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}