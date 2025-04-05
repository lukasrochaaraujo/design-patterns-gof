namespace DesignPatterns._19_Observer;

/// <summary>
/// ConcreteSubject
/// </summary>
public class NewsNotification : INotificationChannel
{
    private List<Channel> _channels = new List<Channel>();
    
    public void Notify(Message message)
    {
        Console.WriteLine();
        foreach (var channel in _channels)
            channel.Send(message);
    }

    public void Register(Channel channel)
    {
        _channels.Add(channel);
    }

    public void Unregister(Channel channel)
    {
        _channels.Remove(channel);
    }
}
