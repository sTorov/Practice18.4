namespace Program.Commands
{
    /// <summary>
    /// Команда для загрузки видео с YouTube
    /// </summary>
    class DownloadCommand : Command
    {
        public DownloadCommand(YoutobeClient receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            Console.WriteLine("Скичивание видео...");
            await _client.DownloadVideo();
        }
    }
}
