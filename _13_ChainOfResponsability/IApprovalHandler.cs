namespace DesignPatterns._13_ChainOfResponsability;

/// <summary>
/// Handle 
/// </summary>
public interface IApprovalHandler
{
    IApprovalHandler Next(IApprovalHandler handler);
    Order? Handle(Order order);
}
