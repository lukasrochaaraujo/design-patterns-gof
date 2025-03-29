namespace DesignPatterns._03_FactoryMethod;

public class SomeStuffService
{
    public void NotifyUser()
    {
        //processing something
        var userNotificationPreference = NotificationType.Email; //was obtained from some repository
        var notificationService = ParametrizedNotificationServiceFactory.Create(userNotificationPreference);
        notificationService.Send("congratulations");
    }
}
