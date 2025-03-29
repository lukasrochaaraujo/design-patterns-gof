namespace DesignPatterns._07_Bridge;

public class Ted : ITransfer
{
    public void Send(decimal amount)
    {
        Console.WriteLine("Transfering with TED");
    }
}
