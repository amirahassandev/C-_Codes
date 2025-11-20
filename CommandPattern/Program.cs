namespace CommandPattern.LampController_Basics;

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


        List<string> commands = commInvoke.ExecuteCommand();
        foreach(string comm in commands)
        {
            System.Console.WriteLine(comm);
        }


    }
}
