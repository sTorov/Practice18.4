using Program.Extensions;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Program
{
    /// <summary>
    /// Объект для обработки полученного URL-адреса видео
    /// </summary>
    class VideoUrlHandler
    {
        private readonly VideoClient _videoClient;
        private readonly Video _video;
        private readonly string _videoUrl;

        public VideoUrlHandler(string videoUrl)
        {
            _videoClient = new VideoClient(new HttpClient());
            _videoUrl = videoUrl;
            _video = _videoClient.GetAsync(_videoUrl).Result;
        }

        /// <summary>
        /// Вывод названия и описания видео в консоль
        /// </summary>
        /// <returns></returns>
        public void GetInfoVideo() => Console.WriteLine(Constants.LINE + "Название:\n" + _video.Title +
                                                        Constants.LINE + "Описание:\n" + _video.Description + 
                                                        Constants.LINE);

        /// <summary>
        /// Скачивание видео
        /// </summary>
        /// <returns></returns>
        public async Task DownloadVideo()
        {
            string downloadVideoTitle = $"{_video.Title.GetCorrectFileName()}.mp4";

            await _videoClient.DownloadAsync(_videoUrl, downloadVideoTitle, builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео успешно загружено");
        }
    }
}
