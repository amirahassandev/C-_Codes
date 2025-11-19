namespace FactoryMethod;

internal class program
{
    static void Main(String[] args)
    {
        var factory = new BackEndDeveloperMethod();
        System.Console.WriteLine(factory.DeveloperInfo("Amira", 3));
    }

}