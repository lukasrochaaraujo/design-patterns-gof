namespace DesignPatterns._20_State;

/// <summary>
/// ConcreteState
/// </summary>
public class PaymentState : State
{
    private decimal _funds = 0;

    public PaymentState(VendingMachine vendingMachine) : base(vendingMachine)
    {
        Console.WriteLine($"PAYMENT - You can insert coins.");
    }

    public override void Cancel()
    {
        Console.WriteLine("Cancelling order.");

        if (_funds > 0)
            Console.WriteLine($"Returning the amount of {_funds}");

        _machine.ClearSelected();
        _machine.ChangeState(new IdleState(_machine));
    }

    public override void DispenseProduct()
       => Console.WriteLine("Cannot dispense product yet. Insuffiecient funds.");

    public override void InsertMoney(decimal money)
    {
        _funds += money;
        var selectedProduct = _machine.GetSelected();
        if (_funds < selectedProduct.Price)
            Console.WriteLine($"Remaining:{selectedProduct.Price - _funds}");
        else
        {
            Console.WriteLine($"Proper amount received.");
            var change = _funds - selectedProduct.Price;
            if (change > 0)
                Console.WriteLine($"Dispensing {change} amount.");

            _machine.ChangeState(new DispenseProductState(_machine));
            _machine.DispenseProduct();
        }
    }

    public override void Refill(List<Product> products)
       => Console.WriteLine("Cannot refill during payment operation. Please cancel or complete payment before refill.");

    public override void SelectProduct(string productCode)
       => Console.WriteLine("Product is already selected. Please complete or cancel the current payment.");
}
