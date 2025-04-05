namespace DesignPatterns._17_Mediator;

/// <summary>
/// ConcreteMediator
/// </summary>
public class DialogBox : IDialogBox
{
    private Button _confirmButton;
    private Button _cancelButton;
    private TextInput _nameInput;

    public DialogBox()
    {
        Console.WriteLine("DialogBox initialized");

        _confirmButton = new Button("Ok", this);
        _cancelButton = new Button("Cancel", this);
        _nameInput = new TextInput(this);
    }

    public void OnChange(Component component)
    {
        if (ReferenceEquals(component, _nameInput))
        {
            if (_nameInput.IsEmpty())
            {
                Console.WriteLine("Input is empty. ConfirmButton was disabled");
                _confirmButton.Disable();
            }
            else
            {
                Console.WriteLine("Input is not empty. ConfirmButton was enabled");
                _confirmButton.Enable();
            }
        }

        if (ReferenceEquals(component, _confirmButton))
        {
            Close();
        }
    }

    public void Close()
    {
        Console.WriteLine("DialogBox was closed.");
    }

    //Simulates one click
    public void ClickOnConfirm()
    {
        _confirmButton.Click();
    }

    //Simulates input
    public void InputText()
    {
        _nameInput.SetText("Hello, input!");
    }
}
