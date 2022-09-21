namespace Program.Commands
{
    class GetInfoVideoCommand : Command
    {
        public GetInfoVideoCommand(YoutobeClient receiver) : base(receiver)
        {
        }

        public override async Task Run()
        {
            await _client.GetInfoVideo();
        }
    }
}
