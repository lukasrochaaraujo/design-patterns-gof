namespace DesignPatterns._19_Observer;

/// <summary>
/// Observer
/// </summary>
public abstract class Channel
{
    public Guid Id { get; private set; }

    public Channel()
    {
        Id = Guid.NewGuid();
    }

    public abstract void Send(Message message);
}
