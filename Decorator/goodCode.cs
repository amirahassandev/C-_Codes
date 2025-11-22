namespace Decorator;

public interface ICoffee
{
    public decimal GetPrice();
}

public class BasicCoffee: ICoffee
{
    public decimal GetPrice()
    {
        return 20;
    }
}

public class MilkDecorator:ICoffee
{
    private readonly ICoffee _coffee;
    public MilkDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 5;
    }

}

public class SugarDecorator: ICoffee
{
    private readonly ICoffee _coffee;
    public SugarDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 2;
    }
}

public class CreamDecorator: ICoffee
{
    private readonly ICoffee _coffee;
    public CreamDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 7;
    }
}

public class VanillaDecorator: ICoffee
{
    private readonly ICoffee _coffee;
    public VanillaDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 10;
    }
}

public class CaramelDecorator: ICoffee
{
    private readonly ICoffee _coffee;
    public CaramelDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 12;
    }
}