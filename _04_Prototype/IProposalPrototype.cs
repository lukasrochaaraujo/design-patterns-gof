namespace DesignPatterns._04_Prototype;

public interface IProposalPrototype
{
    /// <summary>
    /// Deep clone
    /// </summary>
    IProposal Clone();
}
