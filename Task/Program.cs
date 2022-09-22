using Program.Commands;
using Program.Loggers;
using System.Text;

namespace Program
{
    class Program
    {
        static readonly ILogger errorLogger = new ErrorLogger();

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var videoUrlHandler = GetVideoUrlHandler();

            if (videoUrlHandler == null)
                return;

            var sender = new CommandSender();

            sender.SetCommand(new GetTitleVideoCommand(videoUrlHandler));
            await sender.StartCommand();

            sender.SetCommand(new DownloadCommand(videoUrlHandler));
            await sender.StartCommand();

            Console.ReadKey();
        }

        /// <summary>
        /// Получение объекта VideoUrlHandler
        /// </summary>
        /// <returns></returns>
        static VideoUrlHandler GetVideoUrlHandler()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Укажите ссылку на видео:");
                    string url = Console.ReadLine();

                    return new VideoUrlHandler(url);
                }
                catch (ArgumentException)
                {
                    errorLogger.Print("Указан неверный url-адрес, попробуйте снова");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (HttpRequestException)
                {
                    errorLogger.Print("Для работы программы необходимо интернет-соединение");
                    Console.ReadKey();
                    return null;
                }
            }
        }
    }
}