namespace DesignPatterns._06_Adapter;

public interface IPaymentGateway
{
    void Send(Payment payment);
}
