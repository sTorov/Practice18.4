namespace Program.Handlers
{
    /// <summary>
    /// Обработчик нажатия на клавиши
    /// </summary>
    static class PressKeyHandler
    {
        /// <summary>
        /// Проверка наличия символа нажатой клавиши в переданном массиве символов<br/>
        /// Вывод стоки title на консоль<br/>
        /// Символ будет возвращён только при условии наличия в переданном массиве, в противном случае цикл не прервётся
        /// </summary>
        /// <param name="title"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        private static char GetPressKeyChar(string title, char[] chars)
        {
            Console.WriteLine(title);

            char pressKeyChar;

            do
            {
                pressKeyChar = char.ToUpper(Console.ReadKey(true).KeyChar);

                if(chars.Any(ch => ch == pressKeyChar))
                    break;

            } while (true);

            return pressKeyChar;
        }

        /// <summary>
        /// Проверка нажатой клавиши
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool CheckTap(string title)
        {
            bool check = false;
            var ch = GetPressKeyChar(title, new char[] { 'Y', 'N', /*русские символы =>*/ 'Н', 'Т' });

            switch (ch)
            {
                case 'Y':
                case 'Н':
                    check = true;
                    break;
                case 'N':
                case 'Т':
                    break;
            }

            return check;
        }
    }
}
