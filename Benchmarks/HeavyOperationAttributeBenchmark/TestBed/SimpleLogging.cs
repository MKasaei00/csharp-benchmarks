using HeavyOperationAttributeBenchmark.Utility;

namespace HeavyOperationAttributeBenchmark.TestBed;

public class SimpleLogging
{
    public List<string> Load()
    {
        using var log = new Logger("HeavyOperationAttributeBenchmark.TestBed-SimpleLogging-Load");
        return Enumerable.Empty<string>().ToList();
    }
}