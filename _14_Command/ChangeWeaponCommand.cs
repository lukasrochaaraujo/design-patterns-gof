namespace DesignPatterns._14_Command;

/// <summary>
/// ConcreteCommand
/// </summary>
public class ChangeWeaponCommand : ICommand
{
    public void Execute(GameActor actor)
    {
        actor.ChangeWeapon();
    }
}
