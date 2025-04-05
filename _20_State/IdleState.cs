namespace DesignPatterns._20_State;

/// <summary>
/// ConcreteState
/// </summary>
public class IdleState : State
{
    public IdleState(VendingMachine vendingMachine) : base(vendingMachine)
    {
        Console.WriteLine("IDLE - Wait for product selection");
    }

    public override void InsertMoney(decimal money)
    {
        Console.WriteLine("Please select a product before inserting any money.");
    }

    public override void SelectProduct(string productCode)
    {
        var selectedProduct = _machine.Search(productCode);

        if (selectedProduct is null)
        {
            Console.WriteLine($"Product {productCode} not found.");
            return;
        }

        if (selectedProduct.Stock == 0)
        {
            Console.WriteLine($"The product code:{selectedProduct.Code} is out of stock.");
            return;
        }

        _machine.SetSelect(selectedProduct);
        
        Console.WriteLine($"Product:{selectedProduct.Code} with price:{selectedProduct.Price} selected.");
        
        _machine.ChangeState(new PaymentState(_machine));
    }

    public override void DispenseProduct()
       => Console.WriteLine("Select a product first.");

    public override void Cancel()
       => Console.WriteLine("There is no selected product or payment in progress to cancel.");

    public override void Refill(List<Product> products)
    {
        _machine.Refill(products);
        Console.WriteLine($"Total amount of products:{_machine.TotalStock()}");
    }
}
