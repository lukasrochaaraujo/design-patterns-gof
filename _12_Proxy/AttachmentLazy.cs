namespace DesignPatterns._12_Proxy;

/// <summary>
/// Proxy
/// </summary>
public class AttachmentLazy : IAttachment
{
    private readonly Guid _attachmentFileId;
    private IAttachment? _attachment;

    public AttachmentLazy(Guid fileId)
    {
        _attachmentFileId = fileId;
    }

    public byte[] GetFile()
    {
        if (_attachment == null)
            _attachment = new Attachment(_attachmentFileId);

        return _attachment.GetFile();
    }
}
