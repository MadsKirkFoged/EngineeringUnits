using BenchmarkDotNet.Running;
using EngineeringUnits;
#pragma warning disable IDE0060
namespace Benchmark;

internal class Program
{

    private static readonly Enthalpy h1 = Enthalpy.FromJoulePerKilogram(856.75245687853);
    private static readonly Enthalpy h2 = Enthalpy.FromJoulePerKilogram(1456.546239456);
    private static readonly MassFlow m1 = MassFlow.FromKilogramPerSecond(7.4526425854623);
    private static readonly Power P2 = Power.FromWatt(1567.1567896541);
    private static readonly Power P3 = Power.FromWatt(1000.3487624531);

    private static void Main(string[] args)
    {
        test().Wait();
    }

    private static async Task test()
    {


        for (int i = 0; i < 100000000; i++)
        {
            var test1Task = Task.Run(() => Math.Exp(5.345d));
            var test2Task = Task.Run(() => Math.Exp(0.346534d));
            var test3Task = Task.Run(() => Math.Log(0.346534d));
            var test4Task = Task.Run(() => Math.Pow(0.346534, 2));

            await Task.WhenAll(test1Task, test2Task, test3Task, test4Task);

            var test5 = test1Task.Result + test2Task.Result + test3Task.Result * test4Task.Result;

        }






        //BenchmarkRunner.Run<Benchy>();
    } 
}
