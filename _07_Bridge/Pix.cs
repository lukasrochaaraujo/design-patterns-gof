namespace DesignPatterns._07_Bridge;

public class Pix : ITransfer
{
    public void Send(decimal amount)
    {
        Console.WriteLine("Transfering with PIX");
    }
}
