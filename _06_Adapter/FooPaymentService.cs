namespace DesignPatterns._06_Adapter;

/// <summary>
/// Adaptee
/// </summary>
public class FooPaymentService
{
    public bool SendPayment(string accountId, decimal amount)
    {
        //do some stuff
        return true;
    } 
}
