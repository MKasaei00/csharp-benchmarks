using BenchmarkDotNet.Running;

namespace Foreach_Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}