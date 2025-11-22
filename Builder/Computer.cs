namespace Builder;

public class Computer
{
    public string _CPU { get; }
    public int _RAM { get; }
    public int _Storage { get; }
    public string _GraphicCard { get; }
    public string _Monitor { get; }
    public bool _HasRGB { get; }
    public Computer(string CPU, int RAM, int Storage, string GraphicCard, string Monitor, bool HasRGB)
    {
        _CPU = CPU;
        _RAM = RAM;
        _Storage = Storage;
        _GraphicCard = GraphicCard;
        _Monitor = Monitor;
        _HasRGB = HasRGB;
    }
}

public class ComputerBuilder
{
    private string CPU;
    private int RAM;
    private int Storage;
    private string GraphicCard;
    private string Monitor;
    private bool HasRGB; 

    public ComputerBuilder WithCPU(string cpu)
    {
        CPU = cpu;
        return this;
    }
    public ComputerBuilder WithRAM(int ram)
    {
        RAM = ram;
        return this;
    }
    public ComputerBuilder WithStorage(int storage)
    {
        Storage = storage;
        return this;
    }
    public ComputerBuilder WithGraphicCard(string card)
    {
        GraphicCard = card;
        return this;
    }
    public ComputerBuilder WithMonitor(string monitor)
    {
        Monitor = monitor;
        return this;
    }

    public ComputerBuilder WithHasRGB(bool hasRGB)
    {
        HasRGB = hasRGB;
        return this;
    }

    public Computer Build()
    {
        return new Computer(CPU, RAM, Storage, GraphicCard, Monitor, HasRGB);
    }
    
}