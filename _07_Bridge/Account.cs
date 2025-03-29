namespace DesignPatterns._07_Bridge;

public abstract class Account
{
    protected ITransfer _transfer;

    public Account(ITransfer transfer)
    {
        _transfer = transfer;
    }

    public virtual void Transfer(decimal amount)
    {
        _transfer.Send(amount);
    }
}
