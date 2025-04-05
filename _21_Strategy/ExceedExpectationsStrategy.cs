namespace DesignPatterns._21_Strategy;

/// <summary>
/// ConcreteStrategy
/// </summary>
public class ExceedExpectationsStrategy : IBonusCalculationStrategy
{
    public decimal CalculateBonus(decimal baseSalary)
    {
        return (baseSalary * 0.20m) + 1000m;
    }
}
