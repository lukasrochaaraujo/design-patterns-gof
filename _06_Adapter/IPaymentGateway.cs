namespace DesignPatterns._06_Adapter;

/// <summary>
/// Target
/// </summary>
public interface IPaymentGateway
{
    void Send(Payment payment);
}
