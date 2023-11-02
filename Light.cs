public class Light:Appliance
{
    public void ChangeColor(string color){
        switch (color)
        {
            case "Blue":
                System.Console.WriteLine("The Color of the light is changed to blue!!");
                break;
            case "Red":
                System.Console.WriteLine("The Color of the light is changed to red!!");
                break;
            case "Green":
                System.Console.WriteLine("The Color of the light is changed to green!!");
                break;
            default:
                System.Console.WriteLine("You can choose just between blue green and red but now the color is changed to white");
                break;
        }
    }
}