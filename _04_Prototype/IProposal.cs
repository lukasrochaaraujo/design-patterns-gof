namespace DesignPatterns._04_Prototype;

public interface IProposal : IProposalPrototype
{
    Guid Id();
    int DurationMonths();
    void SetAmount(decimal amount);
    decimal Amount();
    ProposalStatus Status();
    void Cancel();
    bool Canceled();
}
