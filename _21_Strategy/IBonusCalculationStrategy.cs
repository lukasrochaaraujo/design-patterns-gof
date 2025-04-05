namespace DesignPatterns._21_Strategy;

/// <summary>
/// Strategy
/// </summary>
public interface IBonusCalculationStrategy
{
    decimal CalculateBonus(decimal baseSalary);
}
