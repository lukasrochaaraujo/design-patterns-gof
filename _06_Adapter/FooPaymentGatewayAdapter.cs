namespace DesignPatterns._06_Adapter;

public class FooPaymentGatewayAdapter : IPaymentGateway
{
    private readonly FooPaymentService fooPaymentService;

    public FooPaymentGatewayAdapter(FooPaymentService fooPaymentService)
    {
        this.fooPaymentService = fooPaymentService;
    }

    public void Send(Payment payment)
    {
        fooPaymentService.SendPayment(payment.DestinationAccount.ToString(), payment.Amount);
    }
}
