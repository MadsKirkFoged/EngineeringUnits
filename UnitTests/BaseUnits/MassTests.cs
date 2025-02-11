using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests.BaseUnits;

[TestClass]
public class MassTests
{

    [TestMethod]
    public void Compare()
    {
        UnitsNet.Mass L1 = new(5674.889, UnitsNet.Units.MassUnit.Kilogram);
        EngineeringUnits.Mass L2 = new(5674.889, MassUnit.Kilogram);

        //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
        Assert.AreEqual(0, L2.As(MassUnit.Centigram) - L1.As(UnitsNet.Units.MassUnit.Centigram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Decigram) - L1.As(UnitsNet.Units.MassUnit.Decigram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Decagram) - L1.As(UnitsNet.Units.MassUnit.Decagram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.EarthMass) - L1.As(UnitsNet.Units.MassUnit.EarthMass), 9.5E-20);
        Assert.AreEqual(0, L2.As(MassUnit.Grain) - L1.As(UnitsNet.Units.MassUnit.Grain), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Gram) - L1.As(UnitsNet.Units.MassUnit.Gram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Hectogram) - L1.As(UnitsNet.Units.MassUnit.Hectogram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Kilogram) - L1.As(UnitsNet.Units.MassUnit.Kilogram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Microgram) - L1.As(UnitsNet.Units.MassUnit.Microgram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Milligram) - L1.As(UnitsNet.Units.MassUnit.Milligram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Nanogram) - L1.As(UnitsNet.Units.MassUnit.Nanogram), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Ounce) - L1.As(UnitsNet.Units.MassUnit.Ounce), 0.0003);
        Assert.AreEqual(0, L2.As(MassUnit.Pound) - L1.As(UnitsNet.Units.MassUnit.Pound), 1.9E-12);
        Assert.AreEqual(0, L2.As(MassUnit.ShortTon) - L1.As(UnitsNet.Units.MassUnit.ShortTon), 0);
        Assert.AreEqual(0, L2.As(MassUnit.Stone) - L1.As(UnitsNet.Units.MassUnit.Stone), 0.0008);
        Assert.AreEqual(0, L2.As(MassUnit.Tonne) - L1.As(UnitsNet.Units.MassUnit.Tonne), 0);

        //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.Mass(65.743, UnitsNet.Units.MassUnit.Pound);
        var A2 = new EngineeringUnits.Mass(65.743, MassUnit.Pound);

        var WorkingCompares = 0;

        foreach (MassUnit EU in UnitTypebase.ListOf<MassUnit>())
        {

            var Error = 1E-5;
            var RelError = 5E-4;

            IEnumerable<UnitsNet.Units.MassUnit> UNList = UnitsNet.Mass.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.MassUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.MassUnit.Nanogram)
                    Error = 0.00390625;

                //Debug.Print($"");
                //Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                //Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                //Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                //Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                //All units absolute difference
                Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                        A1.As(UN)),
                                                        RelError);
                //All units symbol compare
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a")
                                .Replace("klb", "kip")
                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(24, WorkingCompares);
    }
}
