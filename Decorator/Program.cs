namespace Decorator;

internal class Program
{
    public static void Main(string[] args)
    {
        ICoffee coffee = new BasicCoffee();     // 20

        coffee = new MilkDecorator(coffee);      // +5 → 25
        coffee = new SugarDecorator(coffee);     // +2 → 27
        coffee = new CaramelDecorator(coffee);   // +12 → 39

        Console.WriteLine(coffee.GetPrice());    // 39


        ICoffee anotherCoffee = new MilkDecorator(new SugarDecorator(new CaramelDecorator(new BasicCoffee())));
        Console.WriteLine(anotherCoffee.GetPrice()); // 39

    }
}