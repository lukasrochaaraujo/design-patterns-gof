namespace DesignPatterns._01_AbstractFactory;

/// <summary>
/// ConcreteFactory1
/// </summary>
public class MongoFactory : IDatabaseFactory
{
    public IConnection CreateConnection()
    {
        //does some stuff
        return new MongoConnection("connection-string");
    }
}
