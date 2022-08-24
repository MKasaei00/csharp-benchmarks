using BenchmarkDotNet.Attributes;
using InlineMethod.Classes;

namespace InlineMethod;

[MemoryDiagnoser]
public class InlineMethodBenchmark
{
    private const int count = 1_000;
    
    [Benchmark]
    public void NormalCall()
    {
        var adapter = new Adapter() as IAdapter;
        for (var i = 0; i < count; i++)
        {
            adapter.Convert(i);
        }
    }
    
    [Benchmark]
    public void InlineMethodCall()
    {
        var adapter = new Adapter() as IAdapter;
        for (var i = 0; i < count; i++)
        {
            adapter.InlineConvert(i);
        }
    }
}