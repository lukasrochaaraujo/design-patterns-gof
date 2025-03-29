namespace DesignPatterns._06_Adapter;

public class SellerPaymentService
{
    private IPaymentGateway _gateway;

    public SellerPaymentService(IPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Transfer(Payment payment)
    {
        _gateway.Send(payment);
    }
}
