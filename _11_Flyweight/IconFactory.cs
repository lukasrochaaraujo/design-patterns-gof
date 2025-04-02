namespace DesignPatterns._11_Flyweight;

/// <summary>
/// FlyweightFactory
/// </summary>
public class IconFactory
{
    private const int MAX_ICON_TYPE = 7;

    private Dictionary<IconType, Icon> _iconRegistry;

    public IconFactory()
    {
        _iconRegistry = new Dictionary<IconType, Icon>(MAX_ICON_TYPE);
    }

    public Icon Get(IconType type)
    {
        if (_iconRegistry.TryGetValue(type, out Icon? icon))
            return icon;

        icon = new Icon(type);
        _iconRegistry[type] = icon;
        return icon;
    }
}
