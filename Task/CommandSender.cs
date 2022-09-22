using Program.Commands;

namespace Program
{
    /// <summary>
    /// Отправитель команд
    /// </summary>
    class CommandSender
    {
        private Command _command;

        /// <summary>
        /// Задать команду
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(Command command)
        {
            _command = command;
        }

        /// <summary>
        /// Запустить команду
        /// </summary>
        /// <returns></returns>
        public async Task StartCommand()
        {
            await _command.Run();
        }
    }
}
