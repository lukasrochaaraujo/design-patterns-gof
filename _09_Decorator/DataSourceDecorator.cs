namespace DesignPatterns._09_Decorator;

/// <summary>
/// DecoratorBase
/// </summary>
public abstract class DataSourceDecorator : IDataSource
{
    protected IDataSource _wrappee;

    public DataSourceDecorator(IDataSource wrappee)
    {
        _wrappee = wrappee;
    }

    public virtual void Save(string data)
    {
        _wrappee.Save($"DataSourceDecorator: {data}");
    }
}
