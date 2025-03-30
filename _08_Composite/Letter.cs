namespace DesignPatterns._08_Composite;

/// <summary>
/// Leaf
/// </summary>
public class Letter : LetterComponent
{
    private char _character;

    public Letter(char character)
    {
        _character = character;
    }

    protected override void PrintThisBefore()
    {
        Console.Write(_character);
    }
}
