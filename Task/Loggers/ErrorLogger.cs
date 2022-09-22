namespace Program.Loggers
{
    /// <summary>
    /// Логгер ошибок
    /// </summary>
    class ErrorLogger : ILogger
    {
       public void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
