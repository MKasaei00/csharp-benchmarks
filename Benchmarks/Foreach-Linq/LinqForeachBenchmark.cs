using BenchmarkDotNet.Attributes;

namespace Foreach_Linq;

public class LinqForeachBenchmark
{
    private const int ListSize = 1000_000;
    private readonly List<int> list = Enumerable.Range(1, ListSize).ToList();

    [Benchmark]
    public void IterateThoroughForeach()
    {
        var sum = 0L;
        foreach (var item in list)
        {
            sum += item;
        }
    }

    [Benchmark]
    public void IterateThoroughForeachLinq()
    {
        var sum = 0L;
        list.ForEach(i => sum += i);
    }

    [Benchmark]
    public void IterateThoroughForeachLinqAggregate()
    {
        var sum = list.Aggregate(0L, (current, item) => current + item);
    }
}