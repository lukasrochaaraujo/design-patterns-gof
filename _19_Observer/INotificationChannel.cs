namespace DesignPatterns._19_Observer;

/// <summary>
/// Subject
/// </summary>
public interface INotificationChannel
{
    void Register(Channel channel);
    void Unregister(Channel channel);
    void Notify(Message message);
}
