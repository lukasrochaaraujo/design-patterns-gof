namespace DesignPatterns._16_Iterator;

/// <summary>
/// Iterator
/// </summary>
public interface IIterator<T>
{
    void Start();
    T Current();
    void Next();
    bool Done();
}
