namespace Task1
{
    /// <summary>
    /// Конфигурация
    /// </summary>
    public class AppSettings
    {
        private static AppSettings instance;
        public string URL { get; set; }
        public string Path { get; set; }
        private AppSettings()
        { }

        public static AppSettings getInstance()
        {
            if (instance == null)
                instance = new AppSettings();
            return instance;
        }
    }
}
