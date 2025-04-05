namespace DesignPatterns._16_Iterator;

public class Book
{
    public string Isbn { get; private set; } = new Random().NextInt64(100000000000, 999999999999).ToString();
}
