namespace FactoryMethod;

//#######################################################################################
      // Developer

public class Developer
{
    public string Name { get; set; }
    public int ExperienceYears { get; set; }
    public decimal Salary { get; set; }
}

public interface IDeveloperServiceFactory
{
    public Developer CreateDeveloper(string name, int expYears);
}

public abstract class DeveloperMethodFactory
{
    public string DeveloperInfo(string name, int expYears) // CALL
    {
        Developer dev = CreateDeveloperMethod().CreateDeveloper(name, expYears);
        return $"Name: {dev.Name}, ExperienceYears: {dev.ExperienceYears}, Salary: {dev.Salary}";
    }

    public abstract IDeveloperServiceFactory CreateDeveloperMethod();

}

//#######################################################################################4
   // Client

                // FrontEnd Developer
public class FrontEndDeveloperProcessor: IDeveloperServiceFactory
{
    public Developer CreateDeveloper(string name, int expYears)
    {
        return new Developer
            {
                Name = name,
                ExperienceYears = expYears,
                Salary = 8000 + expYears * 500
            };
    }
}

public class FrontEndDeveloperMethod: DeveloperMethodFactory
{
    public override IDeveloperServiceFactory CreateDeveloperMethod()
    {
        return new FrontEndDeveloperProcessor();
    }
}

                // Backend Developer
public class BackEndDeveloperProcessor: IDeveloperServiceFactory
{
    public Developer CreateDeveloper(string name, int expYears)
    {
        return new Developer
            {
                Name = name,
                ExperienceYears = expYears,
                Salary = 9000 + expYears * 700
            };
    }
}

public class BackEndDeveloperMethod: DeveloperMethodFactory
{
    public override IDeveloperServiceFactory CreateDeveloperMethod()
    {
        return new BackEndDeveloperProcessor();
    }
}

