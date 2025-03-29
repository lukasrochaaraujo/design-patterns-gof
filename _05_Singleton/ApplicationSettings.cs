namespace DesignPatterns._05_Singleton;

public class ApplicationSettings
{
    public int Version { get; set; } = new Random().Next(1, 100);
}
