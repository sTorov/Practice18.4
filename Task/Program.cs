using Program.Commands;
using Program.Handlers;
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

            while (true)
            {
                try
                {
                    Console.WriteLine("Укажите ссылку на видео:");
                    string url = Console.ReadLine();

                    var videoUrlHandler = new VideoUrlHandler(url);

                    var sender = CommandSender.GetCommandSenderObj();

                    sender.SetCommand(new GetInfoVideoCommand(videoUrlHandler));
                    await sender.StartCommand();

                    if(PressKeyHandler.CheckTap(Constants.LINE + "Скачать видео? [Y/N]" + Constants.LINE))
                    {
                        sender.SetCommand(new DownloadCommand(videoUrlHandler));
                        await sender.StartCommand();
                    }
                    if(PressKeyHandler.CheckTap(Constants.LINE + "Продолжить? [Y/N]" + Constants.LINE))
                    {
                        Console.Clear();
                        continue;
                    }

                    return;
                }
                catch (ArgumentException)
                {
                    errorLogger.Print(Constants.ARGUMENT_EXCEPTION_MSG);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch(HttpRequestException)
                {
                    errorLogger.Print(Constants.HTTP_REQUEST_EXCEPTION_MSG);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception e)
                {
                    errorLogger.Print(Constants.UNKNOWN_EXCEPTION_MSG + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
        }        
    }
}