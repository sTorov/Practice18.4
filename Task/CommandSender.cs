using Program.Commands;

namespace Program
{
    class CommandSender
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public async Task StartCommand()
        {
            await _command.Run();
        }
    }
}
