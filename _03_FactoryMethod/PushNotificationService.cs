namespace DesignPatterns._03_FactoryMethod;

/// <summary>
/// ConcreteProduct
/// </summary>
public class PushNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}
