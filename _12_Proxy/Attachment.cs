using System.Text;

namespace DesignPatterns._12_Proxy;

/// <summary>
/// RealSubject
/// </summary>
public class Attachment : IAttachment
{
    private readonly Guid _fileId;
    private byte[]? _file;

    public Attachment(Guid fileId)
    {
        _fileId = fileId;
        LoadFile();
    }

    private void LoadFile()
    {
        Console.WriteLine("Some expensive computing...");
        Task.Delay(5000).Wait();

        _file = Encoding.UTF8.GetBytes(_fileId.ToString());

        Console.WriteLine("Attachment file loaded!");
    }

    public byte[] GetFile()
    {
        return _file!;
    }
}
