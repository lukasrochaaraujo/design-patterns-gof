namespace DesignPatterns._03_FactoryMethod;

public class PushNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}
