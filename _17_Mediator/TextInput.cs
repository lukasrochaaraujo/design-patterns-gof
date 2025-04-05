namespace DesignPatterns._17_Mediator;

/// <summary>
/// ConcreteColleague
/// </summary>
public class TextInput : Component
{
    public string _text = string.Empty;

    public TextInput(IDialogBox dialogBox) 
        : base(dialogBox) 
    { 
        OnChange(this);
    }

    public bool IsEmpty()
    {
        return string.IsNullOrEmpty(_text);
    }

    public void SetText(string text)
    {
        _text = text;
        Console.WriteLine($"TextInput: {text}");
        _dialogBox.OnChange(this);
    }
}
