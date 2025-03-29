namespace DesignPatterns._01_AbstractFactory;

/// <summary>
/// ConcreteFactory2
/// </summary>
public class PostgreSqlFactory : IDatabaseFactory
{
    public IConnection CreateConnection()
    {
        //does some stuff
        return new PostgreSqlConnection("connection-string");
    }
}
