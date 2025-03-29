namespace DesignPatterns._02_Builder;

/// <summary>
/// Director
/// </summary>
public abstract class PaymentRequestDirector
{
    public static IPaymentRequest BuildFooStandardSubscription(PaymentRequestBuilder builder)
    {
        return builder
            .WithGateway(PaymentGateway.Foo)
            .WithAmount(49.59m)
            .WithCurrency(Currency.Brl)
            .WithMethod(PaymentMethod.Credit)
            .Build();
    }

    public static IPaymentRequest BuildFooGoldSubscription(PaymentRequestBuilder builder)
    {
        return builder
            .WithGateway(PaymentGateway.Foo)
            .WithAmount(119.99m)
            .WithCurrency(Currency.Brl)
            .WithMethod(PaymentMethod.Credit)
            .Build();
    }
}
