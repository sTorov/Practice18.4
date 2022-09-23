using Program.Handlers;

namespace Program.Commands
{
    /// <summary>
    /// Команда для скачивания видео с YouTube
    /// </summary>
    class DownloadCommand : Command
    {
        public DownloadCommand(VideoUrlHandler receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            Console.WriteLine("Скачивание видео...");
            await _client.DownloadVideo();
        }
    }
}
