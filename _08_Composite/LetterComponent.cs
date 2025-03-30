namespace DesignPatterns._08_Composite;

/// <summary>
/// Component (using array structure)
/// </summary>
public abstract class LetterComponent
{
    private List<LetterComponent> _children = new();

    public int Count { get => _children.Count; }

    public void Add(LetterComponent letter)
    {
        _children.Add(letter);
    }

    protected virtual void PrintThisBefore() { }

    protected virtual void PrintThisAfter() { }

    public void Print()
    {
        PrintThisBefore();
        _children.ForEach(x => x.Print());
        PrintThisAfter();
    }
}
