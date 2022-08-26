using HeavyOperationAttributeBenchmark.Utility;

namespace HeavyOperationAttributeBenchmark.TestBed;

public class AttributeLogging
{
    [HeavyOperation]
    public List<string> Load()
    {
        return Enumerable.Empty<string>().ToList();
    }
}