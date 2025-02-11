using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumeTests
{

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Volume(65.743, UnitsNet.Units.VolumeUnit.Liter);
        var A2 = new EngineeringUnits.Volume(65.743, VolumeUnit.Liter);

        var WorkingCompares = 0;

        foreach (VolumeUnit EU in UnitTypebase.ListOf<VolumeUnit>())
        {

            var Error = 1E-4;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.VolumeUnit> UNList = UnitsNet.Volume.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.VolumeUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer)
                    Error = 8;
                if (UN == UnitsNet.Units.VolumeUnit.CubicInch)
                    Error = 0.015668552908209676;
                if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer)
                    Error = 8;
                if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer)
                    Error = 8;
                if (UN == UnitsNet.Units.VolumeUnit.CubicMicrometer)
                    Error = 8;

                Debug.Print($"");
                Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");
                Debug.Print($"EngineeringUnit: {A2.ToUnit(EU).DisplaySymbol()}");
                Debug.Print($"UnitsNets:       {A1.ToUnit(UN):a}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(51, WorkingCompares);
    }

    [TestMethod]
    public void FromVolume01()
    {
        double? value = null;

        var v = EngineeringUnits.Volume.From(value, null);
        Assert.IsNull(v);

    }

    [TestMethod]
    public void FromVolume02()
    {
        double? value = 100;
        var v = EngineeringUnits.Volume.From(value, VolumeUnit.CubicFoot);
        var v2 = EngineeringUnits.Volume.From(value, null);
        Assert.IsNotNull(v);
        Assert.IsNull(v2);

    }
}
