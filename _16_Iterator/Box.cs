using System.Collections.Immutable;

namespace DesignPatterns._16_Iterator;

/// <summary>
/// Aggregate
/// </summary>
public class Box : IAggragate<Book>
{
    private const int MAX_CAPACITY = 8;
    private List<Book> _books = new(MAX_CAPACITY);

    public int Size()
    {
        return _books.Count;
    }

    public bool Empty()
    {
        return _books.Count == 0;
    }

    public void Put(Book book)
    {
        if (Full()) 
            throw new InvalidOperationException("Box is full.");

        if (_books.Any(x => x.Isbn == book.Isbn))
            throw new InvalidOperationException($"Book [{book.Isbn}] already added.");

        _books.Add(book);
    }

    private bool Full()
    {
        return _books.Count == MAX_CAPACITY;
    }

    public void Clear()
    {
        _books.Clear();
    }

    public IIterator<Book> Iterator()
    {
        return new BoxIterator(_books.ToImmutableList());
    }
}
