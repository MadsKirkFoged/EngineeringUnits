using BenchmarkDotNet.Running;
#pragma warning disable IDE0060
namespace Benchmark;

internal class Program
{
    private static void Main(string[] args) => BenchmarkRunner.Run<Benchy>();
}
