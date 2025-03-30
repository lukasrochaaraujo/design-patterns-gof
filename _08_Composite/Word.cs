namespace DesignPatterns._08_Composite;

/// <summary>
/// Composite
/// </summary>
public class Word : LetterComponent
{
    public Word(List<Letter> letters)
    {
        letters.ForEach(Add);
    }

    public Word(params char[] letters)
    {
        foreach (var letter in letters)
            Add(new Letter(letter));
    }

    protected override void PrintThisBefore()
    {
        Console.Write(" ");
    }
}
