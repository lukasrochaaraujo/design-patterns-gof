namespace DesignPatterns._17_Mediator;

/// <summary>
/// ConcreteColleague
/// </summary>
public class Button : Component
{
    private string _label;

    public Button(string label, IDialogBox dialogBox) 
        : base(dialogBox)
    { 
        _label = label;
    }

    public void Click()
    {
        Console.WriteLine($"Button ({_label}): click event.");
        if (Enabled())
        {
            Console.WriteLine($"Button ({_label}) [ENABLED]: click event notifiy DialogBox");
            OnChange(this);
        }
        else
        {
            Console.WriteLine($"Button ({_label}) [DISABLED]: click event does nothing.");
        }
    }
}
