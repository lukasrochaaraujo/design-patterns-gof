namespace DesignPatterns._01_AbstractFactory;

public interface IDatabaseFactory
{
    IConnection CreateConnection();
}
