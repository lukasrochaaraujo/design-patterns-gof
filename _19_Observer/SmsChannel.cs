namespace DesignPatterns._19_Observer;

/// <summary>
/// ConcreteObserver
/// </summary>
public class SmsChannel : Channel
{
    public SmsChannel() : base() { }

    public override void Send(Message message)
    {
        Console.WriteLine($"[SMS]: Sending message={message.content}");
    }
}
