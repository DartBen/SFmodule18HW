using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task1
{
    /// <summary>
    /// Команда скачивания видео
    /// </summary>
    class GetVideoCommand : Command
    {
        YoutubeClient receiver;
        AppSettings settings;
        public GetVideoCommand(YoutubeClient r, AppSettings appSettings)
        {
            receiver = r;
            settings = appSettings;
        }
        public override async Task Execute()
        {
            var streamManifest = await receiver.Videos.Streams.GetManifestAsync(settings.URL);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await receiver.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}
