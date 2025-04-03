namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// AbstractHandle
/// </summary>
public abstract class AbstractApprovalHandler : IApprovalHandler
{
    private IApprovalHandler _next;

    public IApprovalHandler Next(IApprovalHandler handler)
    {
        _next = handler;
        return handler;
    }

    public virtual Order? Handle(Order order)
    {
        if (_next is null) return null;
        return _next.Handle(order);
    }
}
