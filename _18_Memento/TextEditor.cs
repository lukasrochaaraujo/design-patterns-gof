namespace DesignPatterns._18_Memento;

/// <summary>
/// CareTaker
/// </summary>
public class TextEditor
{
    private TextWindow _textWindow;
    private TextWindowState? _savedTextWindow;

    public TextEditor(TextWindow textWindow)
    {
        _textWindow = textWindow;
        Save();
    }

    public void Write(string text)
    {
        _textWindow.AddText(text);
    }

    public void Print()
    {
        Console.WriteLine("# Editor content:");
        Console.Write(_textWindow.Text());
    }

    public void Save()
    {
        _savedTextWindow = _textWindow.Save();
    }

    public void Undo()
    {
        if (_savedTextWindow != null) _textWindow.Restore(_savedTextWindow);
    }
}
