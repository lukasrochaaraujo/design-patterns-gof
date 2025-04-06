namespace DesignPatterns._22_TemplateMethod;

/// <summary>
/// ConcreteClass
/// </summary>
public class SalesReport : ReportGenerator
{
    protected override void BuildReport()
    {
        Console.WriteLine("[SalesReport] Building report.");
    }

    protected override void CollectData()
    {
        Console.WriteLine("[SalesReport] Fetching data from sales report database.");
    }

    protected override void ExportReport()
    {
        Console.WriteLine("[SalesReport] Saving report into sales storage.");
    }

    protected override void PrepareData()
    {
        Console.WriteLine("[SalesReport] Parsing external data to report structure.");
    }
}
