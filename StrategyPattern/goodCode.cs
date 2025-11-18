namespace StrategyPattern;

public enum ShippingSeviceCategory
{
    Egypt,
    Saudi,
    UAE
}

public interface IShippingServiceStrategy
{
    public decimal CalculateShipping(decimal weight);

}

public class EgyptShippingSevice: IShippingServiceStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return 50 + weight * 2;
    }
}

public class SaudiShippingSevice: IShippingServiceStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return 100 + weight * 3;
    }
}

public class UAEShippingSevice: IShippingServiceStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return 120 + weight * 4;
    }
}

public class CountryShippingSevice: IShippingServiceStrategy
{
    public decimal CalculateShipping(decimal weight)
    {
        return 200 + weight * 5;
    }
}


public class ShippingService
{
    IShippingServiceStrategy _shippingServiceStrategy = null;
    public ShippingService(IShippingServiceStrategy shippingServiceStrategy){
        _shippingServiceStrategy = shippingServiceStrategy;
    }
    public decimal GetCalculateShipping(decimal weight)
    {
        return _shippingServiceStrategy.CalculateShipping(weight);
    }
}

public static class ShippingServiceFactory
{
    public static IShippingServiceStrategy Create(ShippingSeviceCategory category)
    {
        return category switch
        {
            ShippingSeviceCategory.Egypt => new EgyptShippingSevice(),
            ShippingSeviceCategory.Saudi => new SaudiShippingSevice(),
            ShippingSeviceCategory.UAE => new UAEShippingSevice(),
            _ => new CountryShippingSevice(),
        };
    }
}