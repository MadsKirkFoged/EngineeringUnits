using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumeConcentrationTest
{

    [TestMethod]
    public void VolumeConcentrationAutoTest()
    {
        var A1 = new UnitsNet.VolumeConcentration(1, UnitsNet.Units.VolumeConcentrationUnit.LitersPerLiter);
        var A2 = new EngineeringUnits.Ratio(1, RatioUnit.LitersPerLiter);

        var WorkingCompares = 0;

        foreach (RatioUnit EU in UnitTypebase.ListOf<RatioUnit>())
        {

            var Error = 3E-3;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.VolumeConcentrationUnit> UNList = UnitsNet.VolumeConcentration.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.VolumeConcentrationUnit UN = UNList.Single();

                //if (UN == UnitsNet.Units.VolumeConcentrationUnit.PicowattPerCubicFoot) Error = 0.0625;

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
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol().Replace("-", ""),
                            A1.ToUnit(UN).ToString("a")

                            //.Replace("L/L", "l/l")
                            .Replace("L", "l")
                            );

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(20, WorkingCompares);

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