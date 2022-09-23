using Program.Handlers;

namespace Program.Commands
{
    /// <summary>
    /// Общий абстракный класс команд
    /// </summary>
    abstract class Command
    {
        protected VideoUrlHandler _client;

        public Command(VideoUrlHandler client)
        {
            _client = client;
        }

        /// <summary>
        /// Запуск
        /// </summary>
        /// <returns></returns>
        public abstract Task Run();
    }
}
