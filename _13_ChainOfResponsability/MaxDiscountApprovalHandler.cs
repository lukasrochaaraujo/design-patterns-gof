namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// ConcreteHandle1
/// </summary>
public sealed class MaxDiscountApprovalHandler : AbstractApprovalHandler
{
    public override Order? Handle(Order order)
    {
        if (order.DiscountPercentage() > 50)
            order.Add(Approval.DiscountOver50Percent);

        return base.Handle(order);
    }
}
