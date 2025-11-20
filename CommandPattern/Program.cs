// namespace CommandPattern.SmartHome;
namespace CommandPattern.LampController;
internal class program
{
    public static void Main(string[] args)
    {
        CommandInvoker commInvoke = new CommandInvoker();
        Lamp lamp = new Lamp();

        commInvoke.AddCommand(new IsOnCommand(lamp));
        commInvoke.AddCommand(new IncreaseBrightnessCommand(lamp));
        commInvoke.AddCommand(new IsOffCommand(lamp));
        
        commInvoke.AddCommand(new IncreaseBrightnessCommand(lamp));
        


        List<string> commands = commInvoke.ExecuteCommands();
        commInvoke.Undo();
        commInvoke.Redo();
        

        foreach(string comm in commands)
        {
            System.Console.WriteLine(comm);
        }


        // ##############################################################################//
          // ################ Invoker ################
        // CommandInvoker commInvoke = new CommandInvoker();
        // SmartHomeSystem routineBtn = new SmartHomeSystem();

        // commInvoke.AddCommand(new TurnOnLamp(routineBtn));
        // commInvoke.AddCommand(new OpenCurtain(routineBtn));
        // commInvoke.AddCommand(new SetTemperature(routineBtn, "22"));
        // commInvoke.AddCommand(new StartCoffee(routineBtn));


        // List<string> commands = commInvoke.ExecuteCommand();
        // foreach(string comm in commands)
        // {
        //     System.Console.WriteLine(comm);
        // }

    // ############################################################################################
         // ############# Invoker + Macro ##################
        // SmartHomeSystem smart = new SmartHomeSystem();

        // var morningMacro = new MacroCommand(new List<ICommand>
        // {
        //     new TurnOnLamp(smart),
        //     new OpenCurtain(smart),
        //     new SetTemperature(smart, "22"),
        //     new StartCoffee(smart)
        // });

        // var invoker = new CommandInvoker();

        // invoker.AddCommand(morningMacro);

        // var results = invoker.ExecuteCommand();

        // foreach (var msg in results)
        // {
        //     Console.WriteLine(msg);
        // }

    }
}
