namespace TestCodes;

public record Student(string name, int age, Address address);

public class Address
{
    public string StreetName { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return $"StreetName: {StreetName}, City: {City}";
    }

}