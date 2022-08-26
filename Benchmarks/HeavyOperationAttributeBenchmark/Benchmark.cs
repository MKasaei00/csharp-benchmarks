using BenchmarkDotNet.Attributes;
using HeavyOperationAttributeBenchmark.TestBed;

namespace HeavyOperationAttributeBenchmark;

[MemoryDiagnoser]
public class Benchmark
{
    private const int count = 1000;

    [Benchmark]
    public void NoLogging()
    {
        var business = new NoLoggingBusiness();
        for (var i = 0; i < count; i++)
        {
            business.Load();
        }
    }

    [Benchmark]
    public void SimpleLogging()
    {
        var business = new SimpleLogging();
        for (var i = 0; i < count; i++)
        {
            business.Load();
        }
    }

    [Benchmark]
    public void AttributeLogging()
    {
        var business = new AttributeLogging();
        for (var i = 0; i < count; i++)
        {
            business.Load();
        }
    }
}