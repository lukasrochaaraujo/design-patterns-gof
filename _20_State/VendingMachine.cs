namespace DesignPatterns._20_State;

/// <summary>
/// Context
/// </summary>
public class VendingMachine
{
    private List<Product> _products = new();
    private Product? _selectedProduct;
    private State _state;

    public VendingMachine(List<Product> products)
    {
        _products = products;
        _state = new IdleState(this);
    }

    public void Select(string? code)
    {
        _state.SelectProduct(code ?? string.Empty);
    }

    public Product? Search(string code)
    {
        return _products.FirstOrDefault(x => x.Code == code);
    }

    public void SetSelect(Product product)
    {
        _selectedProduct = product;
    }

    public Product GetSelected()
    {
        if (_selectedProduct == null)
            throw new InvalidOperationException("Error");

        return _selectedProduct;
    }

    public void ClearSelected()
    {
        _selectedProduct = null;
    }

    public void DispenseProduct()
    {
        _state.DispenseProduct();
    }

    public void Refill(List<Product> products)
    {
        _products = products;
    }

    public int TotalStock()
    {
        return _products.Sum(p => p.Stock);
    }

    public bool OutOfStock()
    {
        return TotalStock() == 0;
    }

    public void ListAllProducts()
    {
        foreach (var product in _products)
            Console.WriteLine(product);
    }

    public void ChangeState(State state)
    {
        _state = state;
    }

    internal void InsertMoney(decimal money)
    {
        _state.InsertMoney(money);
    }
}
