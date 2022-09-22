namespace Program.Commands
{
    class GetTitleVideoCommand : Command
    {
        public GetTitleVideoCommand(YoutobeClient receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            await _client.GetTitleVideo();
        }
    }
}
