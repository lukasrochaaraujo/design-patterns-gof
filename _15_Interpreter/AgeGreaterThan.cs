namespace DesignPatterns._15_Interpreter;

/// <summary>
/// TerminalExpression
/// </summary>
public class AgeGreaterThan : ICustomerRuleExpression
{
    private readonly int _value;

    public AgeGreaterThan(int value)
    {
        _value = value;
    }

    public bool Interpret(Customer customer)
    {
        return customer.Age > _value;
    }
}
