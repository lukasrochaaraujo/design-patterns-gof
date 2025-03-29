namespace DesignPatterns._04_Prototype;

/// <summary>
/// ConcretePrototype
/// </summary>
public class SaleProposal : IProposal
{
    //Other complex properties

    private readonly Guid _id = Guid.NewGuid();
    private int _durationMonths = 12;
    private decimal _totalAmount = 0;
    private ProposalStatus _status = ProposalStatus.Canceled;

    public SaleProposal(int durationMonths, decimal totalAmount)
    {
        _durationMonths = durationMonths;
        _totalAmount = totalAmount;
        _status = ProposalStatus.Created;
    }

    public Guid Id() => _id;

    public int DurationMonths() => _durationMonths;

    public void SetAmount(decimal amount) => _totalAmount = amount;

    public decimal Amount() => _totalAmount;

    public ProposalStatus Status() => _status;

    public void Delete() => _status = ProposalStatus.Deleted;

    public void Cancel() => _status = ProposalStatus.Canceled;

    public bool Canceled() => _status == ProposalStatus.Canceled;

    public IProposal Clone()
    {
        return new SaleProposal(_durationMonths, _totalAmount);
    }
}
