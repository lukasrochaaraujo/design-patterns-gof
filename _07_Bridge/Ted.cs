namespace DesignPatterns._07_Bridge;

/// <summary>
/// ConcreteImplementorB
/// </summary>
public class Ted : ITransfer
{
    public void Send(decimal amount)
    {
        Console.WriteLine("Transfering with TED");
    }
}
