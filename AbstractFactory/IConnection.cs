namespace DesignPatterns.AbstractFactory;

public interface IConnection
{
    ConnectionStatus Status { get; }
    void Open();
}
