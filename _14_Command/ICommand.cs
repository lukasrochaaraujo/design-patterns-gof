namespace DesignPatterns._14_Command;

/// <summary>
/// Command
/// </summary>
public interface ICommand
{
    void Execute(GameActor actor);
}
