namespace DesignPatterns._02_Builder;

public class FooPaymentRequest : IPaymentRequest
{
    public decimal Amount { get; private set; }
    public string CurrencyCode { get; private set; } = string.Empty;
    public string PaymentMethodCode { get; private set; } = string.Empty;
    
    public FooPaymentRequest(
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
                CurrencyCode = "002";
                break;
            case Currency.Brl:
                CurrencyCode = "001";
                break;
        }
    }

    private void SetPaymentMethod(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.Credit:
                PaymentMethodCode = "CRD";
                break;
            case PaymentMethod.Debit:
                PaymentMethodCode = "DBT";
                break;
        }
    }
}
