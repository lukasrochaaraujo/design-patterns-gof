namespace DesignPatterns._11_Flyweight;

/// <summary>
/// Flyweight
/// </summary>
public class Icon
{
    public IconType Type { get; private set; }
    public string Path { get; private set; }

    public Icon(IconType type)
    {
        Type = type;
        Path = $"/icons/{nameof(Icon)}.svg";
    }
}
