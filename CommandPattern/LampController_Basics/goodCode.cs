namespace CommandPattern.LampController_Basics;

public class Lamp
{
    private int _brightness = 50;
    private bool _isOn = false;
    
    public string IsOn()
    {
        _isOn = true;
        return "Lamp turned ON";
    }

    public string IsOff()
    {
        _isOn = false;
        return "Lamp turned OFF";
    }

    public string Inc()
    {
        _brightness += 10;
        return $"Brightness increased to {_brightness}";
    }

    public string Dec()
    {
        _brightness -= 10;
        return $"Brightness decreased to {_brightness}";
    }

}

public interface ICommand
{
    public string Execute();
}

public class CommandInvoker
{
    public List<ICommand> Commands = new();
    public void AddCommand(ICommand command)
    {
        Commands.Add(command);
    }

    // public void ExecuteCommand()
    // {
    //     int i = 1;
    //     foreach (ICommand com in Commands)
    //     {
    //         System.Console.WriteLine($"Command #{i++} => {com.Execute()}");
    //     }
    // }

    public List<string> ExecuteCommand()
    {
        List<string> commandsReturn = new List<string>();
        foreach (ICommand com in Commands)
        {
            commandsReturn.Add(com.Execute());
        }
        return commandsReturn;
    }
}

public class IsOnCommand: ICommand
{
    private readonly Lamp _lamp;
    public IsOnCommand(Lamp lamp)
    {
        _lamp = lamp;
    }
    public string Execute()
    {
        return _lamp.IsOn();
    }
}

public class IsOffCommand: ICommand
{
    private readonly Lamp _lamp;
    public IsOffCommand(Lamp lamp)
    {
        _lamp = lamp;
    }
    public string Execute()
    {
        return _lamp.IsOff();
    }
}

public class IncreaseBrightnessCommand: ICommand
{
    private readonly Lamp _lamp;
    public IncreaseBrightnessCommand(Lamp lamp)
    {
        _lamp = lamp;
    }
    public string Execute()
    {
        return _lamp.Inc();
    }
}

public class DecreaseBrightnessCommand: ICommand
{
    private readonly Lamp _lamp;
    public DecreaseBrightnessCommand(Lamp lamp)
    {
        _lamp = lamp;
    }
    public string Execute()
    {
        return _lamp.Dec();
    }
}