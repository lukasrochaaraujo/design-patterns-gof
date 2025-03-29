namespace DesignPatterns._03_FactoryMethod;

public class SmsNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
