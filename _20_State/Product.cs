namespace DesignPatterns._20_State;

public class Product
{
    public string Code { get; private set; }
    public int Stock { get; private set; }
    public decimal Price { get; private set; }

    public Product(string code, int stock, decimal price)
    {
        Code = code;
        Stock = stock;
        Price = price;
    }

    public void ReduceStock()
    {
        Stock--;
    }

    public override string ToString()
    {
        return $" Code: {Code} | Stock: {Stock} | Price: {Price}";
    }
}
