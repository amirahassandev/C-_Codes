namespace ChainOfResponsibility;

public class Complaint
{
    public string _Message { get; set; }
    public int _Level { get; set; }

    public Complaint(string Message, int Level)
    {
        _Message = Message;
        _Level = Level;
    }
}

public interface IComplaintHandler
{
    public void SetNextHandler(IComplaintHandler Next);
    public void Process(Complaint complaint);
}

public abstract class ComplaintHandler: IComplaintHandler
{
    private IComplaintHandler _next;
    public void SetNextHandler(IComplaintHandler Next)
    {
        _next = Next;
    }
    public abstract void Process(Complaint complaint);
    public void CallNext(Complaint complaint)
    {
        if(complaint != null)
        {
            _next.Process(complaint);
        }
    }
}

public class CustomerServiceHandler : ComplaintHandler
{
    public override void Process(Complaint complaint)
    {
        if(complaint._Level <= 1)
        {
            System.Console.WriteLine("Customer Service handled the complaint.");
        }
        else
        {
            CallNext(complaint);
        }
    }
}

public class TeamLeaderHandler : ComplaintHandler
{
    public override void Process(Complaint complaint)
    {
        if(complaint._Level <= 2)
        {
            System.Console.WriteLine("Team Leader Handler handled the complaint.");
        }
        else
        {
            CallNext(complaint);
        }
    }
}

public class ManagerHandler : ComplaintHandler
{
    public override void Process(Complaint complaint)
    {
        if(complaint._Level <= 3)
        {
            System.Console.WriteLine("Manager Handler handled the complaint.");
        }
        else
        {
            CallNext(complaint);
        }
    }
}

public class CEOHandler : ComplaintHandler
{
    public override void Process(Complaint complaint)
    {
        if(complaint._Level <= 4)
        {
            System.Console.WriteLine("CEO Handler handled the complaint.");
        }
        else
        {
            CallNext(complaint);
        }
    }
}