namespace DesignPatterns._07_Bridge;

/// <summary>
/// RefinedAbstraction
/// </summary>
public class CurrentAccount : Account
{
    public CurrentAccount(ITransfer transfer) 
        : base(transfer) { }

    public override void Transfer(decimal amount)
    {
        base.Transfer(amount);
    }
}
