namespace DesignPatterns._19_Observer;

/// <summary>
/// ConcreteObserver
/// </summary>
public class EmailChannel : Channel
{
    public EmailChannel() : base() { }

    public override void Send(Message message)
    {
        Console.WriteLine($"[Email]: Sending message={message.content}");
    }
}
