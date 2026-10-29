using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in value)
            {
                if (c != 'p')
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public string DeleteCharInString(string value, char item)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in value)
            {
                if (c != item)
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}