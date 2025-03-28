namespace DesignPatterns.AbstractFactory;

public class PostgreSqlConnection : IConnection
{
    private readonly string _connectionString;
    private ConnectionStatus _status = ConnectionStatus.Closed;
    public ConnectionStatus Status => _status;

    public PostgreSqlConnection(string connectionString)
    {
        _connectionString = connectionString;        
    }

    public void Open()
    {
        //todo: open connection with database PostgreSQL
        _status = ConnectionStatus.Open;
    }
}
