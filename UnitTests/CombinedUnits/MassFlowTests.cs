using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests.CombinedUnits;

[TestClass]
public class MassFlowTests
{

    [TestMethod]
    public void Compare()
    {

        UnitsNet.MassFlow L1 = new(45442, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
        EngineeringUnits.MassFlow L2 = new(45442, MassFlowUnit.PoundPerMinute);

        Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerHour), 4);
        Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerMinute), 0.06);
        Assert.AreEqual(0, L2.As(MassFlowUnit.KilogramPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.KilogramPerSecond), 0.00093);
        Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour), 7);
        Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerMinute) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerMinute), 0);
        Assert.AreEqual(0, L2.As(MassFlowUnit.PoundPerSecond) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerSecond), 0.0021);
    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.MassFlow(65.743, UnitsNet.Units.MassFlowUnit.KilogramPerHour);
        var A2 = new EngineeringUnits.MassFlow(65.743, MassFlowUnit.KilogramPerHour);

        var WorkingCompares = 0;

        foreach (MassFlowUnit EU in UnitTypebase.ListOf<MassFlowUnit>())
        {

            var Error = 7E-4;
            var RelError = 3E-4;

            IEnumerable<UnitsNet.Units.MassFlowUnit> UNList = UnitsNet.MassFlow.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MassFlowUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.MassFlowUnit.NanogramPerDay)
                    Error = 0.25;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");
                Debug.Print($"UnitsNets:       {A1.ToUnit(UN):a}");
                Debug.Print($"EngineeringUnit: {A2.ToUnit(EU).DisplaySymbol()}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol()
                                .Replace("day", "d"),
                                A1.ToUnit(UN).ToString("a")
                                //.Replace("min", "m")
                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(33, WorkingCompares);
    }
}
