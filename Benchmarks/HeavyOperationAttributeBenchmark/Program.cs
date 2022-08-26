using BenchmarkDotNet.Running;

namespace HeavyOperationAttributeBenchmark;

class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run(typeof(Program).Assembly);
    }
}