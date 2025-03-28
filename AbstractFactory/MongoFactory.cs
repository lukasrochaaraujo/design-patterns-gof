namespace DesignPatterns.AbstractFactory;

public class MongoFactory : IDatabaseFactory
{
    public IConnection CreateConnection()
    {
        //does some stuff
        return new MongoConnection("connection-string");
    }
}
