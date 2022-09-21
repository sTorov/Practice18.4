using Program.Commands;
using System.Text;

namespace Program
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Укажите ссылку на видео:");
            string url = Console.ReadLine();

            var downloader = new YoutobeClient(url);
            var sender = new CommandSender();

            sender.SetCommand(new GetInfoVideoCommand(downloader));
            await sender.StartCommand();

            sender.SetCommand(new DownloadCommand(downloader));
            await sender.StartCommand();

            Console.ReadKey();
        }
    }
}