namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// ConcreteHandle2
/// </summary>
public sealed class NoCustomerApprovalHandler : AbstractApprovalHandler
{
    public override Order? Handle(Order order)
    {
        if (!order.HasCustomer())
            order.Add(Approval.NoCustomer);

        return base.Handle(order);
    }
}
