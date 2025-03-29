namespace DesignPatterns._02_Builder;

public class BarPaymentRequest : IPaymentRequest
{
    public decimal Amount { get; private set; }
    public string CurrencyCode { get; private set; } = string.Empty;
    public string PaymentMethodCode { get; private set; } = string.Empty;

    public BarPaymentRequest(
        decimal amount, 
        Currency currency,
        PaymentMethod paymentMethod)
    {
        Amount = amount;
        SetCurrency(currency);
        SetPaymentMethod(paymentMethod);
    }

    private void SetCurrency(Currency currency)
    {
        switch (currency)
        {
            case Currency.Usd:
                CurrencyCode = "USD";
                break;
            case Currency.Brl:
                CurrencyCode = "BRL";
                break;
        }
    }

    private void SetPaymentMethod(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.Credit:
                PaymentMethodCode = "CREDIT_CARD";
                break;
            case PaymentMethod.Debit:
                PaymentMethodCode = "DEBIT_CARD";
                break;
        }
    }

    public string Body()
    {
        throw new NotImplementedException();
    }
}
