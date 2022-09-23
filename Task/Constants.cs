namespace Program
{
    /// <summary>
    /// Текстовые постоянные значения
    /// </summary>
    static class Constants
    {
        /// <summary>
        /// Разделительная линия
        /// </summary>
        public static readonly string LINE = "\n--------------------\n";

        /// <summary>
        /// Сообщение при возниковении ArgumentException
        /// </summary>
        public static readonly string ARGUMENT_EXCEPTION_MSG = "Неверно указан URL-адрес видео, попробуйте снова";

        /// <summary>
        /// Сообщение при возниковении HttpRequestException
        /// </summary>
        public static readonly string HTTP_REQUEST_EXCEPTION_MSG = "Не удалось установить интернет-соединение";

        /// <summary>
        /// Сообщение при возниковении других исключений
        /// </summary>
        public static readonly string UNKNOWN_EXCEPTION_MSG = "Неизвестная ошибка\n";

    }
}
