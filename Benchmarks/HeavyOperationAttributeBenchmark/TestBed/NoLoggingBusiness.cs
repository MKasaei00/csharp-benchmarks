namespace HeavyOperationAttributeBenchmark.TestBed;

public class NoLoggingBusiness
{
    public List<string> Load()
    {
        return Enumerable.Empty<string>().ToList();
    }
}