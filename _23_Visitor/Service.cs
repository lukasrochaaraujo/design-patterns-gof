namespace DesignPatterns._23_Visitor;

/// <summary>
/// ConcreteElement
/// </summary>
public class Service : Product
{
    public override void Accept(ITaxCalculator visitor)
    {
        visitor.Visit(this);
    }
}
