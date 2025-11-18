namespace TemplateMethod;

public abstract class BaseReportGenerator
{
    
    public void GenerateReport()
    {
        ConnectingDB();
        LoadingData();
        FormattingData();
        ExportingReport(); /// abstract method
        SendingNotification();
    }

    private void ConnectingDB()
    {
        Console.WriteLine("Connecting to DB...");
    }


    private void LoadingData()
    {
        Console.WriteLine("Loading data...");
    }

    private void FormattingData()
    {
        Console.WriteLine("Formatting data...");
    }

    public abstract void ExportingReport();

    private void SendingNotification()
    {
        Console.WriteLine("Sending notification...");
    }

}



public class PdfReport: BaseReportGenerator
{

    public override void ExportingReport()
    {
        Console.WriteLine("Exporting PDF...");
    }
}

public class ExcelReport: BaseReportGenerator
{
    public override void ExportingReport()
    {
        Console.WriteLine("Exporting Excel...");
    }
}

public class WordReport: BaseReportGenerator
{
    public override void ExportingReport()
    {
        Console.WriteLine("Exporting Word...");
    }
}