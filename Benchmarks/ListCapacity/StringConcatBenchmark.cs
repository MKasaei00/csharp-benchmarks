using BenchmarkDotNet.Attributes;

namespace ListCapacity;

[MemoryDiagnoser]
public class ListCapacityBenchmark
{
    private const int count = 1_000;

    [Benchmark]
    public void AddToList()
    {
        var list = new List<int>();
        for (int i = 0; i < count; i++)
        {
            list.Add(1);
        }
    }


    [Benchmark]
    public void AddToListWithCapacity()
    {
        var list = new List<int>(count);
        for (int i = 0; i < count; i++)
        {
            list.Add(1);
        }
    }
}