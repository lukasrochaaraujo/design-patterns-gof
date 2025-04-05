namespace DesignPatterns._21_Strategy;

/// <summary>
/// Context
/// </summary>
public class Employee
{
    public string Name { get; private set; } = "";
    public decimal BaseSalary { get; private set; }

    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public decimal CalculateYearEndBonus(IBonusCalculationStrategy strategy)
    {
        return strategy.CalculateBonus(BaseSalary);
    }

    public override string ToString()
    {
        return $"Name: {Name}, BaseSalary: {BaseSalary}";
    }
}
