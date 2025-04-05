namespace DesignPatterns._18_Memento;

/// <summary>
/// Memento
/// </summary>
public class TextWindowState
{
    private string _text;

    public TextWindowState(string text)
    {
        _text = text;
    }

    public string Text()
    {
        return _text;
    }
}
