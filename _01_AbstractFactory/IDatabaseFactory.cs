namespace DesignPatterns._01_AbstractFactory;

/// <summary>
/// AbstractFactory
/// </summary>
public interface IDatabaseFactory
{
    IConnection CreateConnection();
}
