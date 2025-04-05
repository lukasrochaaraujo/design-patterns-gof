namespace DesignPatterns._15_Interpreter;

/// <summary>
/// TerminalExpression
/// </summary>
public class MonthlyIncomeGreaterThan : ICustomerRuleExpression
{
    private readonly decimal _value;

    public MonthlyIncomeGreaterThan(decimal value)
    {
        _value = value;
    }

    public bool Interpret(Customer customer)
    {
        return customer.MonthlyIncome > _value;
    }
}
