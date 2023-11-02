using SmartHoustSystemControl;

public class Appliance : Controllable
{
    public bool IsOn()
    {
        return true;
    }

    public void TurnOff()
    {
        System.Console.WriteLine("The devise is turned Off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("The devise is turned On");
    }
}