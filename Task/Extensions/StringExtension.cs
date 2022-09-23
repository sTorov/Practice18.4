using System.Text.RegularExpressions;

namespace Program.Extensions
{
    /// <summary>
    /// String - расширения
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Замена любых символов, не образующих слово (пробелы, знаки препинания, спецсимволы), на нижнее подчёркивание<br/>
        /// Сокращение повторяющихся нижних подчёркиваний до одного<br/>
        /// Удаление всех нижних подчёркиваний в начале и конце строки
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetCorrectFileName(this string input)
        {
            return Regex.Replace(input, @"\W+", "_").Trim('_');
        }
    }
}
