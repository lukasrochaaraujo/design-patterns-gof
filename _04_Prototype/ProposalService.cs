namespace DesignPatterns._04_Prototype;

/// <summary>
/// Client
/// </summary>
public class ProposalService
{
    public IProposal Copy(IProposal proposal)
    {
        proposal.Delete();

        //do some stuff

        var newProposal = proposal.Clone();

        //do some stuff

        return newProposal;
    }
}
