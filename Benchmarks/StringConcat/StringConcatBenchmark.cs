using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace StringConcat;

[MemoryDiagnoser]
public class StringConcatBenchmark
{
    private const int count = 1_000;
    private List<string> ids;

    public StringConcatBenchmark()
    {
        ids = Enumerable
            .Range(0, count)
            .Select(i => Guid.NewGuid().ToString())
            .ToList();
    }

    [Benchmark]
    public void ConcatStrings()
    {
        var newString = "";
        foreach (var id in ids)
        {
            newString += id;
        }
    }


    [Benchmark]
    public void StringBuilder()
    {
        var buffer = new StringBuilder();
        foreach (var id in ids)
        {
            buffer.Append(id);
        }
    }

    [Benchmark]
    public void StringBuilderWithCapacity()
    {
        var buffer = new StringBuilder(32 * count);
        foreach (var id in ids)
        {
            buffer.Append(id);
        }
    }
}