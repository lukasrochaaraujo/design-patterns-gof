namespace DesignPatterns._14_Command;

/// <summary>
/// ConcreteCommand
/// </summary>
public class FireCommand : ICommand
{
    public void Execute(GameActor actor)
    {
        actor.Fire();
    }
}
