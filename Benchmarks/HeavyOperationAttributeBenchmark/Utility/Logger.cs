namespace HeavyOperationAttributeBenchmark.Utility;

public class Logger : IDisposable
{
    private readonly string _scopeName;

    public Logger(string scopeName = "")
    {
        _scopeName = scopeName;
        Console.WriteLine($"Log scope started => {_scopeName}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Log scope finished => {_scopeName}");
    }
}