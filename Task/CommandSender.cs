using Program.Commands;

namespace Program
{
    /// <summary>
    /// Отправитель команд
    /// </summary>
    class CommandSender
    {
        private Command _command;
        private static CommandSender _sender;

        private CommandSender() { }

        /// <summary>
        /// Получение объекта-отправителя команд
        /// </summary>
        /// <returns></returns>
        public static CommandSender GetCommandSenderObj()
        {
            if (_sender == null)
                _sender = new CommandSender();
            return _sender;
        }

        /// <summary>
        /// Назначить команду
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
