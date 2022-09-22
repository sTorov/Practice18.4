using System.Text.RegularExpressions;

namespace Program.Extensions
{
    /// <summary>
    /// String - расширения
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Замена всех пробельных и недопустимых в имени файла символов на нижнее подчёркивание<br/>
        /// Сокращение повторяющихся нижних подчёркиваний до одного<br/>
        /// Удаление нижних подчёркиваний в начале и конце строки
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetCorrectFileName(this string input)
        {
            return Regex.Replace(input, @"\W+", "_").Trim('_');
        }
    }
}
