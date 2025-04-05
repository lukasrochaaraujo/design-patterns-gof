namespace DesignPatterns._16_Iterator;

/// <summary>
/// Aggregate
/// </summary>
public interface IAggragate<T>
{
    IIterator<T> Iterator();
}
