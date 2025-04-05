namespace DesignPatterns._17_Mediator;

/// <summary>
/// Colleague
/// </summary>
public abstract class Component
{
    protected IDialogBox _dialogBox;
    protected bool _disabled;

    public Component(IDialogBox dialogBox)
    {
        _dialogBox = dialogBox;
    }

    protected void OnChange(Component component)
    {
        _dialogBox.OnChange(component);
    }

    public void Disable()
    {
        _disabled = true;
    }

    public bool Disabled()
    {
        return _disabled;
    }

    public void Enable()
    {
        _disabled = false;
    }

    public bool Enabled()
    {
        return !_disabled;
    }
}
