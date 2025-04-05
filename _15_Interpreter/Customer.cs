namespace DesignPatterns._15_Interpreter;

/// <summary>
/// Context
/// </summary>
public class Customer
{
    public int Age { get; }
    public decimal MonthlyIncome { get; }

    public Customer(int age, decimal monthlyIncome)
    {
        Age = age;
        MonthlyIncome = monthlyIncome;
    }
}
