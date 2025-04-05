namespace DesignPatterns._20_State;

/// <summary>
/// ConcreteState
/// </summary>
public class DispenseProductState : State
{
    public DispenseProductState(VendingMachine vendingMachine) : base(vendingMachine)
    {
        Console.WriteLine("DISPENSE");
    }

    public override void Cancel()
       => Console.WriteLine("Cannot cancel dispensing operation.");

    public override void DispenseProduct()
    {
        var selectedProduct = _machine.GetSelected();
        if (selectedProduct is null)
        {
            Console.WriteLine("There is no selected product to dispense.");
            _machine.ChangeState(new IdleState(_machine));
            return;
        }

        Console.WriteLine("Dispensing product.");
        Thread.Sleep(2000); // dispensing the product..

        selectedProduct.ReduceStock(); // update the new stock of the product.
        _machine.ClearSelected(); // the selected product is sold.
        
        Console.WriteLine("Product dispensed.");

        // we check if there are other products left for selling.
        if (_machine.OutOfStock())
            _machine.ChangeState(new SoldOutState(_machine));
        else
            _machine.ChangeState(new IdleState(_machine));
    }

    public override void InsertMoney(decimal money)
       => Console.WriteLine("Cannot insert money during product dispensing.");

    public override void Refill(List<Product> products)
       => Console.WriteLine("Cannot refill during dispensing product.");

    public override void SelectProduct(string productCode)
       => Console.WriteLine("Product already selected.");
}