namespace DesignPatterns.AbstractFactory;

public class PostgreSqlFactory : IDatabaseFactory
{
    public IConnection CreateConnection()
    {
        //does some stuff
        return new PostgreSqlConnection("connection-string");
    }
}
