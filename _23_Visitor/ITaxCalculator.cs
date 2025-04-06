namespace DesignPatterns._23_Visitor;

/// <summary>
/// Visitor
/// </summary>
public interface ITaxCalculator
{
    public void Visit(Service service);
    public void Visit(IndustrialProduct industrialProduct);
}
