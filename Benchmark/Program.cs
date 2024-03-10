using BenchmarkDotNet.Running;

namespace Benchmark;

internal class Program
{
    private static void Main(string[] args) => BenchmarkRunner.Run<Benchy>();
}
