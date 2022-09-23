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
                    PrintError(Constants.ARGUMENT_EXCEPTION_MSG);
                    continue;
                }
                catch(HttpRequestException)
                {
                    PrintError(Constants.HTTP_REQUEST_EXCEPTION_MSG);
                    continue;
                }
                catch (Exception e)
                {
                    PrintError(Constants.UNKNOWN_EXCEPTION_MSG + e.Message);
                    continue;
                }
            }
        }
        
        /// <summary>
        /// Вывод сообщения об ошибке и очистка консоли
        /// </summary>
        /// <param name="value"></param>
        static void PrintError(string value)
        {
            errorLogger.Print(value);
            Console.ReadKey();
            Console.Clear();
        }
    }
}