using Program.Extensions;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace Program
{
    class YoutobeClient
    {
        private VideoClient _videoClient;
        private Video _video;
        private string _videoUrl;

        public YoutobeClient(string videoUrl)
        {
            _videoClient = new VideoClient(new HttpClient());
            _videoUrl = videoUrl;
        }

        public async Task GetTitleVideo()
        {
            _video = await _videoClient.GetAsync(_videoUrl);
            Console.WriteLine(Constants.LINE + "Название: " + _video.Title + Constants.LINE);
        }

        public async Task DownloadVideo()
        {
            string downloadVideoTitle = _video.Title.ReplacePunctuations();

            await _videoClient.DownloadAsync(_videoUrl, $"{downloadVideoTitle}.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео успешно загружено");
        }
    }
}
