namespace DesignPatterns._15_Interpreter;

/// <summary>
/// NonterminalExpression
/// </summary>
public class AndExpression : ICustomerRuleExpression
{
    private readonly ICustomerRuleExpression _left;
    private readonly ICustomerRuleExpression _right;

    public AndExpression(ICustomerRuleExpression left, ICustomerRuleExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(Customer customer)
    {
        return _left.Interpret(customer) && _right.Interpret(customer);
    }
}
