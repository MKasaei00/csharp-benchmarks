using BenchmarkDotNet.Attributes;

namespace CreateNewInLoop;

[MemoryDiagnoser]
public class CreateInLoopBenchmark
{
    private const int count = 1_000;

    [Benchmark]
    public void CreateInLoop()
    {
        for (var i = 0; i < count; i++)
        {
            new Adapter().Convert(i);
        }
    }


    [Benchmark]
    public void CreateOnce()
    {
        var adapter = new Adapter() as IAdapter;
        for (var i = 0; i < count; i++)
        {
            adapter.Convert(i);
        }
    }
}