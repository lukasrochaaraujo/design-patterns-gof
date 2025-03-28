namespace DesignPatterns.AbstractFactory;

public interface IDatabaseFactory
{
    IConnection CreateConnection();
}
