namespace DesignPatterns._02_Builder;

/// <summary>
/// Builder
/// </summary>
public interface IPaymentRequestBuilder
{
    IPaymentRequestBuilder WithAmount(decimal amount);
    IPaymentRequestBuilder WithCurrency(Currency currency);
    IPaymentRequestBuilder WithMethod(PaymentMethod method);
    IPaymentRequestBuilder WithInstallments(int count);
    IPaymentRequestBuilder WithDiscount(decimal discount);
    IPaymentRequestBuilder WithGateway(PaymentGateway gateway);
    IPaymentRequest Build();
}
