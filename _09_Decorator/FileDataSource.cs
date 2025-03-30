namespace DesignPatterns._09_Decorator;

/// <summary>
/// ConcreteComponent
/// </summary>
public class FileDataSource : IDataSource
{
    public void Save(string data)
    {
        Console.WriteLine($"FileDataSource: {data}");
    }
}
