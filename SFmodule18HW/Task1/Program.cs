using Task1;
using YoutubeExplode;

internal class Program
{
    private static async Task Main(string[] args)
    {

        //Попытка использования синглтона для хранения конфигурации
        AppSettings settings = AppSettings.getInstance();
        settings.URL = "https://youtube.com/shorts/ll4veEpQ-NU?feature=share";
        settings.Path = "";

        //паттерн Команда
        //инициатор команды
        Invoker invoker = new Invoker();
        //получатель команды
        YoutubeClient youtubeClient = new YoutubeClient();

        //Команда 1- получение информации о видео
        GetTitleCommand command = new GetTitleCommand(youtubeClient, settings);
        invoker.SetCommand(command);
        await invoker.Run();

        //Команда 2- загрузка видео
        // бывает подвисает. почему не до конца понимаю
        GetVideoCommand command2 = new GetVideoCommand(youtubeClient, settings);
        invoker.SetCommand(command2);
        await invoker.Run();
    }
}
