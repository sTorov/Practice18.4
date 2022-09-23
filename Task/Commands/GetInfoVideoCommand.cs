using Program.Handlers;

namespace Program.Commands
{
    /// <summary>
    /// Команда для вывода названия и описания видео
    /// </summary>
    class GetInfoVideoCommand : Command
    {
        public GetInfoVideoCommand(VideoUrlHandler receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            _client.GetInfoVideo();
        }
    }
}
