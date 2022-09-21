using System.Text.RegularExpressions;

namespace Program.Extensions
{
    public static class StringExtension
    {
        public static string ReplacePunctuations(this string input)
        {
            return Regex.Replace(input, @"\p{P}", "_");
        }
    }
}
