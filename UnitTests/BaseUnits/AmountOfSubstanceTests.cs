using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.BaseUnits;

[TestClass]
public class AmountOfSubstanceTests
{

    [TestMethod]
    public void Compare()
    {

        UnitsNet.AmountOfSubstance A1 = new(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
        AmountOfSubstance A2 = new(65.743, AmountOfSubstanceUnit.Mole);

        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Centimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.CentipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Decimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole), 0);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.DecipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Kilomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole), 0);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.KilopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Megamole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole), 0);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.MicropoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Micromole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole), 0);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Millimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.MillipoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole), 1E-10);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Mole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole), 0);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.Nanomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole), 7.7E-06);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.NanopoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole), 1E-7);
        Assert.AreEqual(0, A2.As(AmountOfSubstanceUnit.PoundMole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole), 1E-10);

        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentimoles(435).Centimoles - AmountOfSubstance.FromCentimole(435).Centimole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromCentipoundMoles(435).CentipoundMoles - AmountOfSubstance.FromCentipoundMole(435).CentipoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecimoles(435).Decimoles - AmountOfSubstance.FromDecimole(435).Decimole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromDecipoundMoles(435).DecipoundMoles - AmountOfSubstance.FromDecipoundMole(435).DecipoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilomoles(435).Kilomoles - AmountOfSubstance.FromKilomole(435).Kilomole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromKilopoundMoles(435).KilopoundMoles - AmountOfSubstance.FromKilopoundMole(435).KilopoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMegamoles(435).Megamoles - AmountOfSubstance.FromMegamole(435).Megamole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicromoles(435).Micromoles - AmountOfSubstance.FromMicromole(435).Micromole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMicropoundMoles(435).MicropoundMoles - AmountOfSubstance.FromMicropoundMole(435).MicropoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillimoles(435).Millimoles - AmountOfSubstance.FromMillimole(435).Millimole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMillipoundMoles(435).MillipoundMoles - AmountOfSubstance.FromMillipoundMole(435).MillipoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromMoles(435).Moles - AmountOfSubstance.FromMole(435).Mole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanomoles(435).Nanomoles - AmountOfSubstance.FromNanomole(435).Nanomole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromNanopoundMoles(435).NanopoundMoles - AmountOfSubstance.FromNanopoundMole(435).NanopoundMole, 0);
        Assert.AreEqual(0, UnitsNet.AmountOfSubstance.FromPoundMoles(435).PoundMoles - AmountOfSubstance.FromPoundMole(435).PoundMole, 0);

        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Centimole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.CentipoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Decimole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.DecipoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Kilomole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.KilopoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Megamole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Micromole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.MicropoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Millimole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.MillipoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Mole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.Nanomole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.NanopoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(AmountOfSubstanceUnit.PoundMole),
                                                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole)), 1E-10);

        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Centimole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Centimole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.CentipoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Decimole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Decimole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.DecipoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Kilomole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.KilopoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Megamole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Megamole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Micromole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Micromole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.MicropoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Millimole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Millimole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.MillipoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Mole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Mole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.Nanomole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.NanopoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole).ToString("a"));
        Assert.AreEqual(A2.ToUnit(AmountOfSubstanceUnit.PoundMole).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole).ToString("a"));

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole);
        var A2 = new EngineeringUnits.AmountOfSubstance(65.743, AmountOfSubstanceUnit.KilopoundMole);

        var WorkingCompares = 0;

        foreach (AmountOfSubstanceUnit EU in UnitTypebase.ListOf<AmountOfSubstanceUnit>())
        {

            var Error = 8E-3;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.AmountOfSubstanceUnit> UNList = UnitsNet.AmountOfSubstance.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.AmountOfSubstanceUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.AmountOfSubstanceUnit.Nanomole)
                    Error = 4;
                //if (UN == UnitsNet.Units.AreaUnit.SquareMillimeter) Error = 2.629720000550151;

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
                Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                A1.ToUnit(UN).ToString("a"));

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(15, WorkingCompares);
    }

    [TestMethod]
    public void AmountOfSubstance01()
    {
        var a1 = AmountOfSubstance.From(10, AmountOfSubstanceUnit.Centimole);
        Assert.AreEqual(10, a1.Centimole);

        var a2 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Decimole);
        Assert.AreEqual(a1, a2);
    }

    [TestMethod]
    public void AmountOfSubstance02()
    {
        double? value = null;
        var a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
        Assert.IsNull(a);

    }

    [TestMethod]
    public void FromAmountOfSubstance()
    {
        double? value = 100;
        var a = AmountOfSubstance.From(value, AmountOfSubstanceUnit.Centimole);
        var a2 = AmountOfSubstance.From(value, null);
        Assert.IsNotNull(a);
        Assert.IsNull(a2);

    }
}
