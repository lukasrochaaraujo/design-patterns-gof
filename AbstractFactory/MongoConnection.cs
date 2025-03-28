namespace DesignPatterns.AbstractFactory;

public class MongoConnection : IConnection
{
    private readonly string _connectionString;
    private ConnectionStatus _status = ConnectionStatus.Closed;
    public ConnectionStatus Status => _status;

    public MongoConnection(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Open()
    {
        //todo: open connection with database MongoDB
        _status = ConnectionStatus.Open;
    }
}
