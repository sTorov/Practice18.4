namespace Program.Commands
{
    /// <summary>
    /// Команда для вывода названия видео
    /// </summary>
    class GetTitleVideoCommand : Command
    {
        public GetTitleVideoCommand(VideoUrlHandler receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            _client.GetTitleVideo();
        }
    }
}
