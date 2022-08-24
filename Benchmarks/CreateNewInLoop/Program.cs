using BenchmarkDotNet.Running;

namespace CreateNewInLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}