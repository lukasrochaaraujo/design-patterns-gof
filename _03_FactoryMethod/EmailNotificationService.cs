namespace DesignPatterns._03_FactoryMethod;

public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
