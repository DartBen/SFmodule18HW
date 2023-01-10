using YoutubeExplode;

namespace Task1
{
    /// <summary>
    /// Команда получения заголовка
    /// </summary>
    class GetTitleCommand : Command
    {
        YoutubeClient receiver;
        AppSettings settings;
        public GetTitleCommand(YoutubeClient r, AppSettings appSettings)
        {
            receiver = r;
            settings = appSettings;
        }
        public override async Task Execute()
        {
            var video = await receiver.Videos.GetAsync(settings.URL);
            var title = video.Title;
            var description = video.Description;
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Описание: " + description);
        }
    }
}
