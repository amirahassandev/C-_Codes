namespace StatePattern;

internal class program
{
    static void Main(String[] args)
    {
        Order order = new Order();
        System.Console.WriteLine(order.Next());
        System.Console.WriteLine(order.Next());

    }
}