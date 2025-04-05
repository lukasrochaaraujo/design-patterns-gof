namespace DesignPatterns._21_Strategy;

/// <summary>
/// ConcreteStrategy
/// </summary>
public class BelowExpectationsStrategy : IBonusCalculationStrategy
{
    public decimal CalculateBonus(decimal baseSalary)
    {
        return baseSalary * 0.05m;
    }
}
