﻿namespace Program.Commands
{
    /// <summary>
    /// Общий интерфейс команд
    /// </summary>
    abstract class Command
    {
        protected YoutobeClient _client;

        public Command(YoutobeClient client)
        {
            _client = client;
        }

        public abstract Task Run();
    }
}