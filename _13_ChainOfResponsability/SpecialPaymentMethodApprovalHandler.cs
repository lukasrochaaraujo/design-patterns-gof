namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// ConcreteHandle3
/// </summary>
public sealed class SpecialPaymentMethodApprovalHandler : AbstractApprovalHandler
{
    public override Order? Handle(Order order)
    {
        if (order.HasSpecialPaymentMethod())
            order.Add(Approval.SpecialPaymentMethod);

        return base.Handle(order);
    }
}
