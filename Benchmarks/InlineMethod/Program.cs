using BenchmarkDotNet.Running;

namespace InlineMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}