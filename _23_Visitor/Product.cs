namespace DesignPatterns._23_Visitor;

/// <summary>
/// Element
/// </summary>
public abstract class Product
{
    public abstract void Accept(ITaxCalculator visitor);
}
