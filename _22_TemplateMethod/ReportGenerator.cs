namespace DesignPatterns._22_TemplateMethod;

/// <summary>
/// AbstractClass
/// </summary>
public abstract class ReportGenerator
{
    public void Generate()
    {
        CollectData();
        PrepareData();
        BuildReport();
        ExportReport();
    }

    protected abstract void CollectData();
    protected abstract void PrepareData();
    protected abstract void BuildReport();
    protected abstract void ExportReport();
}
