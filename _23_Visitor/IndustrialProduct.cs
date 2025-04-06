namespace DesignPatterns._23_Visitor;

/// <summary>
/// ConcreteElement
/// </summary>
public class IndustrialProduct : Product
{
    public override void Accept(ITaxCalculator visitor)
    {
        visitor.Visit(this);
    }
}
