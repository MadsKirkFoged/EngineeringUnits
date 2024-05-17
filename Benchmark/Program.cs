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


        //for (int i = 0; i < 20000; i++)
        //{
        //    var test = ((m1 * (h2 - h1)) + P2) / P3;
        //}






        BenchmarkRunner.Run<Benchy>();
    } 
}
