using System.Collections.Immutable;

namespace DesignPatterns._16_Iterator;

/// <summary>
/// ConcreteIterator
/// </summary>
public class BoxIterator : IIterator<Book>
{
    private IImmutableList<Book> _books;
    private int _currentIndex = 0;

    public BoxIterator(IImmutableList<Book> books)
    {
        _books = books;
    }

    public Book Current()
    {
        return _books[_currentIndex];
    }

    public bool Done()
    {
        return (_currentIndex + 1) == _books.Count;
    }

    public void Next()
    {
        _currentIndex++;
    }

    public void Start()
    {
        _currentIndex = 0;
    }
}
