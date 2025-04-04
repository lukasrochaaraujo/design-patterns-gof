namespace DesignPatterns._14_Command;

/// <summary>
/// Receiver
/// </summary>
public class GameActor
{
    public void Jump()
    {
        Console.WriteLine("Actor jumped.");
    }

    public void Fire()
    {
        Console.WriteLine("Actor shot.");
    }

    public void Crouch()
    {
        Console.WriteLine("Actor crouched.");
    }

    public void ChangeWeapon()
    {
        Console.WriteLine("Actor changed the weapon.");
    }
}
