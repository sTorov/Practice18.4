namespace Program.Loggers
{
    /// <summary>
    /// Общий интерфейс логгеров
    /// </summary>
    interface ILogger
    {
        /// <summary>
        /// Вывод сообщения
        /// </summary>
        void Print(string message);
    }
}
