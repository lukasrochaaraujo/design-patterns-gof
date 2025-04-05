using System.Text;

namespace DesignPatterns._18_Memento;

/// <summary>
/// Originator
/// </summary>
public class TextWindow
{
    private StringBuilder _text = new StringBuilder();

    public void AddText(string text)
    {
        _text.AppendLine($"-> {text}");
    }

    public string Text()
    {
        return _text.ToString();
    }

    public TextWindowState Save()
    {
        return new TextWindowState(_text.ToString());
    }

    public void Restore(TextWindowState save)
    {
        _text = new StringBuilder(save.Text());
    }
}
