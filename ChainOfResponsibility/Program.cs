namespace ChainOfResponsibility;
internal class program
{
    public static void Main(string[] args)
    {
        CustomerServiceHandler customerServiceHandler = new CustomerServiceHandler();
        TeamLeaderHandler teamLeaderHandler = new TeamLeaderHandler();
        ManagerHandler managerHandler = new ManagerHandler();
        CEOHandler ceoHandler = new CEOHandler();

        customerServiceHandler.SetNextHandler(teamLeaderHandler);
        teamLeaderHandler.SetNextHandler(managerHandler);
        managerHandler.SetNextHandler(ceoHandler);

        Complaint complaint = new Complaint("Internet not working", 3);
        customerServiceHandler.Process(complaint);
    }
}