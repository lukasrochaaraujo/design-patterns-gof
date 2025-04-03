namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// Request
/// </summary>
public class Order
{
    private List<Approval> _requiredApprovals;

    public Order()
    {
        _requiredApprovals = new();
    }

    public void Add(Approval approval)
    {
        _requiredApprovals.Add(approval);
    }

    public bool HasCustomer()
    {
        return false;
    }

    public decimal DiscountPercentage()
    {
        return 51;
    }

    public bool HasSpecialPaymentMethod()
    {
        return false;
    }
}
