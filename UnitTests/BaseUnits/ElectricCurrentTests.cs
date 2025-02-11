using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.BaseUnits;

[TestClass]
public class ElectricCurrentTests
{

    [TestMethod]
    public void Compare()
    {

        UnitsNet.ElectricCurrent A1 = new(0.0000546, UnitsNet.Units.ElectricCurrentUnit.Ampere);
        EngineeringUnits.ElectricCurrent A2 = new(0.0000546, ElectricCurrentUnit.Ampere);

        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Ampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere), 0);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Centiampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere), 0);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Kiloampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere), 0);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Megaampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere), 0);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Microampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere), 0);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Milliampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere), 7E-18);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Nanoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere), 7.3E-12);
        Assert.AreEqual(0, A2.As(ElectricCurrentUnit.Picoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere), 0);

        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromAmperes(435).Amperes - EngineeringUnits.ElectricCurrent.FromAmpere(435).Ampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromCentiamperes(435).Centiamperes - EngineeringUnits.ElectricCurrent.FromCentiampere(435).Centiampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromKiloamperes(435).Kiloamperes - EngineeringUnits.ElectricCurrent.FromKiloampere(435).Kiloampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMegaamperes(435).Megaamperes - EngineeringUnits.ElectricCurrent.FromMegaampere(435).Megaampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMicroamperes(435).Microamperes - EngineeringUnits.ElectricCurrent.FromMicroampere(435).Microampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromMilliamperes(435).Milliamperes - EngineeringUnits.ElectricCurrent.FromMilliampere(435).Milliampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromNanoamperes(435).Nanoamperes - EngineeringUnits.ElectricCurrent.FromNanoampere(435).Nanoampere, 0);
        Assert.AreEqual(0, UnitsNet.ElectricCurrent.FromPicoamperes(435).Picoamperes - EngineeringUnits.ElectricCurrent.FromPicoampere(435).Picoampere, 0);

        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Ampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Centiampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Kiloampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Megaampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Microampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Milliampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Nanoampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere)), 1E-10);
        Assert.AreEqual(0, HelperClass.Percent(A2.As(ElectricCurrentUnit.Picoampere),
                                                A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere)), 1E-10);

        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Ampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Ampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Centiampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Centiampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Kiloampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Kiloampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Megaampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Megaampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Microampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Microampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Milliampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Milliampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Nanoampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Nanoampere).ToString("a"));
        Assert.AreEqual(A2.ToUnit(ElectricCurrentUnit.Picoampere).DisplaySymbol(),
                        A1.ToUnit(UnitsNet.Units.ElectricCurrentUnit.Picoampere).ToString("a"));

    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.ElectricCurrent(65.743, UnitsNet.Units.ElectricCurrentUnit.Kiloampere);
        var A2 = new EngineeringUnits.ElectricCurrent(65.743, ElectricCurrentUnit.Kiloampere);

        var WorkingCompares = 0;

        foreach (ElectricCurrentUnit EU in UnitTypebase.ListOf<ElectricCurrentUnit>())
        {

            var Error = 1E-5;
            var RelError = 1E-5;

            IEnumerable<UnitsNet.Units.ElectricCurrentUnit> UNList = UnitsNet.ElectricCurrent.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ElectricCurrentUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.ElectricCurrentUnit.Nanoampere)
                    Error = 0.0078125;

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
        Assert.AreEqual(8, WorkingCompares);
    }
}