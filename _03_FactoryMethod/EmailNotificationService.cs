namespace DesignPatterns._03_FactoryMethod;

/// <summary>
/// ConcreteProduct
/// </summary>
public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
