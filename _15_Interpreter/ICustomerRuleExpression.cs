namespace DesignPatterns._15_Interpreter;

/// <summary>
/// AbstractExpression
/// </summary>
public interface ICustomerRuleExpression
{
    bool Interpret(Customer customer);
}
