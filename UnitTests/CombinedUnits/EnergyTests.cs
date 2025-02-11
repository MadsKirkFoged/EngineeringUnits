using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class EnergyTests
{
    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Energy(65.743, UnitsNet.Units.EnergyUnit.Joule);
        var A2 = new EngineeringUnits.Energy(65.743, EnergyUnit.Joule);

        var WorkingCompares = 0;

        foreach (EnergyUnit EU in UnitTypebase.ListOf<EnergyUnit>())
        {

            var Error = 7E-5;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.EnergyUnit> UNList = UnitsNet.Energy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.EnergyUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.EnergyUnit.ElectronVolt)
                    Error = 65536;
                if (UN == UnitsNet.Units.EnergyUnit.KiloelectronVolt)
                    Error = 64;
                if (UN == UnitsNet.Units.EnergyUnit.MegaelectronVolt)
                    Error = 0.0625;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol()
                                .Replace("day", "d"),
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(36, WorkingCompares);
    }


    [TestMethod]
    public void Compare()
    {
        UnitsNet.Energy L1 = new(56239676, UnitsNet.Units.EnergyUnit.Joule);
        EngineeringUnits.Energy L2 = new(56239676, EnergyUnit.Joule);

        //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
        Assert.AreEqual(0, L2.As(EnergyUnit.BritishThermalUnit) - L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit), 0.21);
        Assert.AreEqual(0, L2.As(EnergyUnit.Calorie) - L1.As(UnitsNet.Units.EnergyUnit.Calorie), 1.9E-09);
        Assert.AreEqual(0, L2.As(EnergyUnit.ElectronVolt) - L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt), 0);

        //The %-error is still very small
        Assert.AreEqual(0, L2.As(EnergyUnit.FootPound) - L1.As(UnitsNet.Units.EnergyUnit.FootPound), 550);

        Assert.AreEqual(0, L2.As(EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule), 0);
        Assert.AreEqual(0, L2.As(EnergyUnit.KilowattHour) - L1.As(UnitsNet.Units.EnergyUnit.KilowattHour), 0);
        Assert.AreEqual(0, L2.As(EnergyUnit.WattHour) - L1.As(UnitsNet.Units.EnergyUnit.WattHour), 0);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Joule),
                                                L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.BritishThermalUnit),
                                                 L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Calorie),
                                                L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.ElectronVolt),
                                                L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.FootPound),
                                                L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.KilowattHour),
                                                L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.WattHour),
                                                L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0);
    }

    [TestMethod]
    public void Compare2()
    {
        UnitsNet.Energy L1 = new(56239676, UnitsNet.Units.EnergyUnit.BritishThermalUnit);
        EngineeringUnits.Energy L2 = new(56239676, EnergyUnit.BritishThermalUnit);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Joule),
                                                L1.As(UnitsNet.Units.EnergyUnit.Joule)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.BritishThermalUnit),
                                                 L1.As(UnitsNet.Units.EnergyUnit.BritishThermalUnit)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.Calorie),
                                                L1.As(UnitsNet.Units.EnergyUnit.Calorie)), 0.0004);

        //Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.EnergyUnit.ElectronVolt),
        // L1.As(UnitsNet.Units.EnergyUnit.ElectronVolt)), 0);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.FootPound),
                                                L1.As(UnitsNet.Units.EnergyUnit.FootPound)), 0.002);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.KilowattHour),
                                                L1.As(UnitsNet.Units.EnergyUnit.KilowattHour)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(L2.As(EnergyUnit.WattHour),
                                                L1.As(UnitsNet.Units.EnergyUnit.WattHour)), 0.0004);
    }

}
