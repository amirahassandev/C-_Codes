namespace CommandPattern.SmartHome;

public class SmartHomeSystem
{
    private bool _lamp;
    private bool _curtain;
    private string _ac;
    private bool _coffee;

    public SmartHomeSystem(
        bool lamp = false,
        bool curtain = false,
        string ac = "22",
        bool coffee = false)
    {
        _lamp = lamp;
        _curtain = curtain;
        _ac = ac;
        _coffee = coffee;
    }

    

    public string TurnOnLamp()
    {
        _lamp = true;
        return $"Turn On Lamp";
    }

    public string OpenCurtain()
    {
        _curtain = true;
        return $"Open Curtain";
    }

    public string SetTemperature(string value)
    {
        _ac = value;
        return $"Set Temperature on {value}";
    }

    public string StartCoffee()
    {
        _coffee = true;
        return $"Start Coffee";
    }
}

public interface ICommand
{
    public string Execute();
}

public class CommandInvoker
{
    public List<ICommand> Commands = new ();
    public void AddCommand(ICommand command)
    {
        Commands.Add(command);
    }
    public List<string> ExecuteCommand()
    {
        List<string> commandsReturn = new List<string>();
        foreach (ICommand command in Commands)
        {
            commandsReturn.Add(command.Execute());
        }
        ClearCommands();
        return commandsReturn;
    }

    public void ClearCommands()
    {
        Commands.Clear();
    }

    public List<ICommand> GetCommands()
    {
        return Commands;
    }
}

public class MacroCommand: ICommand
{
    private readonly List<ICommand> _commands;
    public MacroCommand(List<ICommand> commands)
    {
        _commands = commands;
    }
    public string Execute()
    {
        var results = new List<string>();
        foreach (var cmd in _commands)
            results.Add(cmd.Execute());

        return string.Join("\n", results);
    }
}

public class TurnOnLamp: ICommand
{
    private readonly SmartHomeSystem _btnRoutine;
    public TurnOnLamp(SmartHomeSystem btnRoutine)
    {
        _btnRoutine = btnRoutine;
    }
    public string Execute()
    {
        return _btnRoutine.TurnOnLamp();
    }
}

public class OpenCurtain: ICommand
{
    private readonly SmartHomeSystem _btnRoutine;
    public OpenCurtain(SmartHomeSystem btnRoutine)
    {
        _btnRoutine = btnRoutine;
    }
    public string Execute()
    {
        return _btnRoutine.OpenCurtain();
    }
}

public class SetTemperature: ICommand
{
    private readonly SmartHomeSystem _btnRoutine;
    private readonly string _temperature;
    public SetTemperature(SmartHomeSystem btnRoutine, string temperature)
    {
        _btnRoutine = btnRoutine;
        _temperature = temperature;
    }
    public string Execute()
    {
        return _btnRoutine.SetTemperature(_temperature);
    }
}

public class StartCoffee: ICommand
{
    private readonly SmartHomeSystem _btnRoutine;
    public StartCoffee(SmartHomeSystem btnRoutine)
    {
        _btnRoutine = btnRoutine;
    }
    public string Execute()
    {
        return _btnRoutine.StartCoffee();
    }
}