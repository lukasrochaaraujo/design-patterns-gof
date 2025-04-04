namespace DesignPatterns._14_Command;

/// <summary>
/// ConcreteCommand
/// </summary>
public class JumpCommand : ICommand
{
    public void Execute(GameActor actor)
    {
        actor.Jump();
    }
}
