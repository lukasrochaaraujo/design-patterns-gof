namespace DesignPatterns._08_Composite;

/// <summary>
/// Composite
/// </summary>
public class Sentence : LetterComponent
{
    public Sentence(List<Word> words)
    {
        words.ForEach(Add);
    }

    protected override void PrintThisAfter()
    {
        Console.Write(".");
    }
}
