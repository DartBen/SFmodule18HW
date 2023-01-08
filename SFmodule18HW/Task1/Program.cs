using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;


internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var youtube = new YoutubeClient();

        string url = "https://youtube.com/watch?v=u_yIGGhubZs";
        string path = "C:\\Users\\Dima\\Desktop\\Repos\\SF Module 18 HW\\SFmodule18HW\\Task1\\bin\\Debug\\net7.0";


        // You can specify either video ID or URL
        var video = await youtube.Videos.GetAsync(url);

        var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
        var author = video.Author.ChannelTitle; // "Blender"
        var duration = video.Duration; // 00:07:20

        youtube.Videos.DownloadAsync(url, path);

        Console.WriteLine(title);
    }
}

