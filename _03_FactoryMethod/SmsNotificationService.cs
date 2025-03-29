namespace DesignPatterns._03_FactoryMethod;

/// <summary>
/// ConcreteProdcut
/// </summary>
public class SmsNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
