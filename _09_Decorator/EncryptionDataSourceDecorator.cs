using System.Security.Cryptography;
using System.Text;

namespace DesignPatterns._09_Decorator;

/// <summary>
/// ConcreteDecoratorA
/// </summary>
public class EncryptionDataSourceDecorator : DataSourceDecorator
{
    public EncryptionDataSourceDecorator(IDataSource wrappee) 
        : base(wrappee) { }

    public override void Save(string data)
    {
        var dataBytes = Encoding.UTF8.GetBytes(data);
        var dataHashed = MD5.HashData(dataBytes);
        Console.Write("EncryptionDataSourceDecorator -> ");
        _wrappee.Save(Encoding.UTF8.GetString(dataHashed));
    }
}
