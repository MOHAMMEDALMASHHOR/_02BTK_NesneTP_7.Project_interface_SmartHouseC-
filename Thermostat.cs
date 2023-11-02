public class Thermostat:Appliance
{
    public void ChangeTemperature(){
        System.Console.WriteLine("You can change the temprature of the house just choose between this values(10,20,30)otherways the temprature will stay the same");
        System.Console.Write("Enter the value as a number: ");
        int value = Convert.ToInt16(Console.ReadLine());
        switch (value)
        {
            case 10:
                System.Console.WriteLine("The Temprature of the house is strated changing to be 10c");
                break;
            case 20:
                System.Console.WriteLine("The Temprature of the house is strated changing to be 20c");
                break;
            case 30:
                System.Console.WriteLine("The Temprature of the house is strated changing to be 30c");
                break;
            default:
                System.Console.WriteLine("Invalid input!!! try again now");
                ChangeTemperature();
                break;
        }
    }
}