namespace DesignPatterns._14_Command;

public static class ButtonMapper
{
    public static Button Map(ConsoleKeyInfo keyInfo)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.B: return Button.B;
            case ConsoleKey.X: return Button.X;
            case ConsoleKey.Y: return Button.Y;
            case ConsoleKey.A: return Button.A;
            case ConsoleKey.Escape: return Button.Start;
            default: return Button.None;
        }
    }
}
