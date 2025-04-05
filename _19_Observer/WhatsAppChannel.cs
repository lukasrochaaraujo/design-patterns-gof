namespace DesignPatterns._19_Observer;

/// <summary>
/// ConcreteObserver
/// </summary>
public class WhatsAppChannel : Channel
{
    public WhatsAppChannel() : base() {}

    public override void Send(Message message)
    {
        Console.WriteLine($"[WhatsApp]: Sending message={message.content}");
    }
}
