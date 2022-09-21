namespace Program.Commands
{
    class DownloadCommand : Command
    {
        public DownloadCommand(YoutobeClient receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            await _client.DownloadVideo();
        }
    }
}
