namespace StrategyPattern;

internal class program
{
    static void Main(String[] args)
    {
        IShippingServiceStrategy shippingServiceStrategy = null;

        System.Console.Write("Write Country Name: ");
        string category = Console.ReadLine();

        System.Console.Write("Write weight: ");
        var weightStr = Console.ReadLine();
        decimal weight = Decimal.Parse(weightStr); 

        var strategy = ShippingServiceFactory.Create(Enum.Parse<ShippingSeviceCategory>(category));
        ShippingService shippingService = new ShippingService(strategy);
        
        System.Console.Write($"shippingService = {shippingService.GetCalculateShipping(weight)}");
    }
}
