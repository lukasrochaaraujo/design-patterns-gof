namespace DesignPatterns._01_AbstractFactory;

public interface IConnection
{
    ConnectionStatus Status { get; }
    void Open();
}
