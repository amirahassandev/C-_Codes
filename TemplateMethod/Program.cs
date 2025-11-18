namespace TemplateMethod;

internal class program
{
    static void Main(String[] args)
    {
        BaseReportGenerator pdf = new PdfReport();
        pdf.GenerateReport();

    }
}