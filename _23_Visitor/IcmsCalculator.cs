namespace DesignPatterns._23_Visitor;

/// <summary>
/// ConcreteVisitor
/// </summary>
public class IcmsCalculator : ITaxCalculator
{
    public void Visit(Service service)
    {
        Console.WriteLine("ICMS does not apply to services.");
    }

    public void Visit(IndustrialProduct industrialProduct)
    {
        Console.WriteLine("ICMS will be applied to the industrial product");
    }
}
