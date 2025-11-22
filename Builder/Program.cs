namespace Builder;

internal class program
{
    public static void Main(string[] args)
    {
        ComputerBuilder builder = new ComputerBuilder();

        Computer computer = builder.WithCPU("Core i7")
        .WithRAM(16)
        .WithStorage(512)
        .WithMonitor("Samsung 24")
        .Build();

        System.Console.WriteLine(computer._Monitor); // Samsung 24
    }
}
