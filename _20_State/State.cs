namespace DesignPatterns._20_State;

/// <summary>
/// State
/// </summary>
public abstract class State
{
    protected readonly VendingMachine _machine;

    protected State(VendingMachine machine)
    {
        _machine = machine;
    }

    public abstract void InsertMoney(decimal amount);
    public abstract void SelectProduct(string productCode);
    public abstract void DispenseProduct();
    public abstract void Refill(List<Product> products);
    public abstract void Cancel();
}
