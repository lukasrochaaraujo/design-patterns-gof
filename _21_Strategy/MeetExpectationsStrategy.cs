namespace DesignPatterns._21_Strategy;

/// <summary>
/// ConcreteStrategy
/// </summary>
public class MeetExpectationsStrategy : IBonusCalculationStrategy
{
    public decimal CalculateBonus(decimal baseSalary)
    {
        return baseSalary * 0.10m;
    }
}
