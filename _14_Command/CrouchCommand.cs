namespace DesignPatterns._14_Command;

/// <summary>
/// ConcreteCommand
/// </summary>
public class CrouchCommand : ICommand
{
    public void Execute(GameActor actor)
    {
        actor.Crouch();
    }
}
