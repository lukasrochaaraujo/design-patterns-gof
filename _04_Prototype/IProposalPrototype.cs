namespace DesignPatterns._04_Prototype;

/// <summary>
/// Prototype
/// </summary>
public interface IProposalPrototype
{
    /// <summary>
    /// Deep clone
    /// </summary>
    IProposal Clone();
}
