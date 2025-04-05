namespace DesignPatterns._20_State;

/// <summary>
/// ConcreteState
/// </summary>
public class SoldOutState : State
{
    public SoldOutState(VendingMachine vendingMachine) : base(vendingMachine)
    {
        Console.WriteLine("SOLDOUT");
    }

    public override void InsertMoney(decimal money)
      => Console.WriteLine($"There are no products in the vending machine");

    public override void SelectProduct(string productCode)
       => Console.WriteLine($"There are no products in the vending machine");

    public override void Cancel()
       => Console.WriteLine($"There is no operation to cancel.");

    public override void DispenseProduct()
       => Console.WriteLine($"There is no selected product.");

    public override void Refill(List<Product> products)
    {
        _machine.Refill(products);
        Console.WriteLine($"Total amount of products:{_machine.TotalStock()}");
        _machine.ChangeState(new IdleState(_machine));
    }
}
