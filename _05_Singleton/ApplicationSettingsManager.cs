namespace DesignPatterns._05_Singleton;

public sealed class ApplicationSettingsManager
{
    private static ApplicationSettings? settings;
    private static Lock settingsLock = new();

    private ApplicationSettingsManager() {}

    public static ApplicationSettings Instance()
    {
        lock (settingsLock)
        {
            if (settings == null)
                CreateInstance();
        }

        return settings!;
    }

    private static void CreateInstance()
    {
        //read configurations from source
        
        settings = new ApplicationSettings();
    }
}
