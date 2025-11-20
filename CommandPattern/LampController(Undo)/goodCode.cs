namespace CommandPattern.LampController;

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
    public string Undo();
}

public class CommandInvoker
{
    public List<ICommand> Commands = new();
    public Stack<ICommand> commandsExecute = new();
    List<string> commandsReturn = new List<string>();
    public void AddCommand(ICommand command)
    {
        Commands.Add(command);
    }

    public List<string> ExecuteCommands()
    {
        foreach (ICommand command in Commands)
        {
            var comm = ExecuteCommand(command);
            commandsReturn.Add(comm);
        }
        return commandsReturn;
    }

    public string ExecuteCommand(ICommand command)
    {
        var commandExe = command.Execute();
        commandsExecute.Push(command);

        return commandExe;
    }

    public void Undo()
    {
        if(commandsExecute.Count > 0)
        {
            var command = commandsExecute.Pop();
            // commandsReturn.remove();
            Console.WriteLine($"UNDO ->>>>: {command.Undo()}");
        }
        else
        {
            Console.WriteLine("No commands to undo.");
        }
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
    public string Undo()
    {
        return _lamp.IsOff();
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
    public string Undo()
    {
        return _lamp.IsOn();
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
    public string Undo()
    {
        return _lamp.Dec();
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
    public string Undo()
    {
        return _lamp.Inc();
    }
}