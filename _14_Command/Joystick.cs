namespace DesignPatterns._14_Command;

/// <summary>
/// Invoker
/// </summary>
public class Joystick
{
    private ICommand _buttonX;
    private ICommand _buttonY;
    private ICommand _buttonB;
    private ICommand _buttonA;

    public Joystick(
        ICommand buttonX,
        ICommand buttonY,
        ICommand buttonB,
        ICommand buttonA
    )
    {
        _buttonX = buttonX;
        _buttonY = buttonY;
        _buttonB = buttonB;
        _buttonA = buttonA;   
    }

    public ICommand? HandleInput(Button buttonPressed)
    {
        switch (buttonPressed)
        {
            case Button.X: return _buttonX;
            case Button.Y: return _buttonY;
            case Button.B: return _buttonB;
            case Button.A: return _buttonA;
            default: return null;
        }
    }

    public void RemapButtons(
        ICommand buttonX,
        ICommand buttonY,
        ICommand buttonB,
        ICommand buttonA
    )
    {
        _buttonX = buttonX;
        _buttonY = buttonY;
        _buttonB = buttonB;
        _buttonA = buttonA;
    }
}
