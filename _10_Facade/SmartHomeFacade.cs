namespace DesignPatterns._10_Facade;

/// <summary>
/// Facade
/// </summary>
public class SmartHomeFacade
{
    private Light light;
    private Thermostat thermostat;
    private DoorLock doorLock;

    public SmartHomeFacade()    
    {
        light = new Light();
        thermostat = new Thermostat();
        doorLock = new DoorLock();
    }

    public void ActivateNightMode()
    {
        light.TurnOff();
        thermostat.Temperature(25);
        doorLock.Lock();
    }
}
