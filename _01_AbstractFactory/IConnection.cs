namespace DesignPatterns._01_AbstractFactory;

/// <summary>
/// AbstractProduct
/// </summary>
public interface IConnection
{
    ConnectionStatus Status { get; }
    void Open();
}
