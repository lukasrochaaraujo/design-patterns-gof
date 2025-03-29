namespace DesignPatterns._02_Builder;

public class PaymentRequestBuilder : IPaymentRequestBuilder
{
    private decimal _amount;
    private Currency _currency;
    private decimal _discount;
    private int _installments;
    private PaymentMethod _method;
    private PaymentGateway _gateway;


    public IPaymentRequestBuilder WithAmount(decimal amount)
    {
        _amount = amount;
        return this;
    }

    public IPaymentRequestBuilder WithCurrency(Currency currency)
    {
        _currency = currency;
        return this;
    }

    public IPaymentRequestBuilder WithDiscount(decimal discount)
    {
        _discount = discount;
        return this;
    }

    public IPaymentRequestBuilder WithInstallments(int count)
    {
        _installments = count;
        return this;
    }

    public IPaymentRequestBuilder WithMethod(PaymentMethod method)
    {
        _method = method;
        return this;
    }

    public IPaymentRequestBuilder WithGateway(PaymentGateway gateway)
    {
        _gateway = gateway;
        return this;
    }

    public IPaymentRequest Build()
    {
        switch (_gateway)
        {
            case PaymentGateway.Foo:
                return new FooPaymentRequest(_amount, _currency, _method);
            case PaymentGateway.Bar:
                return new BarPaymentRequest(_amount, _currency, _method);
            default:
                throw new InvalidOperationException("Gateway not defined.");
        }
    }
}
