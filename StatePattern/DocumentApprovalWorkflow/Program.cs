namespace DocumentApprovalWorkflow;

internal class program
{
    static void Main(String[] args)
    {
        Document doc = new Document();
        System.Console.WriteLine(doc.Submit());
        System.Console.WriteLine(doc.Submit());
        System.Console.WriteLine(doc.Review());
        System.Console.WriteLine(doc.Submit());
        System.Console.WriteLine(doc.Archive());
        System.Console.WriteLine(doc.Reject());





    }
}