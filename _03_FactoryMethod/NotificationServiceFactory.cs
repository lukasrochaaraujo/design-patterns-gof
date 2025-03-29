namespace DesignPatterns._03_FactoryMethod;

/// <summary>
/// ConcreteCreator
/// </summary>
public static class ParametrizedNotificationServiceFactory
{
    public static INotificationService Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Sms => new SmsNotificationService(),
            NotificationType.Email => new EmailNotificationService(),
            NotificationType.Push => new PushNotificationService(),
            _ => throw new ArgumentException("Invalid notification type"),
        };
    }
}
