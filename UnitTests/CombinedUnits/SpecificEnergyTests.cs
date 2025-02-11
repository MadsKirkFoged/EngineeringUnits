using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SpecificEnergyTests
{
    [TestMethod]
    public void Compare()
    {
        UnitsNet.SpecificEnergy L1 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
        EngineeringUnits.SpecificEnergy L2 = new(10, SpecificEnergyUnit.JoulePerKilogram);

        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 1.9E-12);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 0);
    }

    [TestMethod]
    public void Compare2()
    {
        UnitsNet.SpecificEnergy L1 = new(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
        EngineeringUnits.SpecificEnergy L2 = new(1, SpecificEnergyUnit.BtuPerPound);

        //UnitNets and EngineeringUnits does not agree on the exact conversing between JoulePerKilogram -> BtuPerPound
        //That what gives the 'large' different

        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.BtuPerPound) - L1.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 0.1);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.JoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.1);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.CaloriePerGram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-5);
        Assert.AreEqual(0, L2.As(SpecificEnergyUnit.KilojoulePerKilogram) - L1.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.1E-05);
    }

    [TestMethod]
    public void AutoTest()
    {
        var A1 = new UnitsNet.SpecificEnergy(65.743, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);
        var A2 = new EngineeringUnits.SpecificEnergy(65.743, SpecificEnergyUnit.JoulePerKilogram);

        var WorkingCompares = 0;

        foreach (SpecificEnergyUnit EU in UnitTypebase.ListOf<SpecificEnergyUnit>())
        {

            var Error = 1E-5;
            var RelError = 4E-4;

            IEnumerable<UnitsNet.Units.SpecificEnergyUnit> UNList = UnitsNet.SpecificEnergy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.SpecificEnergyUnit UN = UNList.Single();

                if (UN == UnitsNet.Units.SpecificEnergyUnit.BtuPerPound)
                    Error = .0003898557813860592;

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
                                A1.ToUnit(UN).ToString("a")
                                .Replace("btu", "BTU")
                                .Replace("ST", "t (short)")

                                );

                WorkingCompares++;
            }
        }

        //Number of comparables units
        Assert.AreEqual(25, WorkingCompares);
    }

    [TestMethod]
    public void Add()
    {
        UnitsNet.SpecificEnergy UnitNet1 = new(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
        UnitsNet.SpecificEnergy UnitNet2 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

        EngineeringUnits.SpecificEnergy EngineeringUnits1 = new(1, SpecificEnergyUnit.BtuPerPound);
        EngineeringUnits.SpecificEnergy EngineeringUnits2 = new(10, SpecificEnergyUnit.JoulePerKilogram);

        UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 + UnitNet2;
        EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound),
                                                UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound)), 0.00042);

        Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram),
                                    UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram)), 0.00042);

        Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram),
                                    UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram)), 0.00042);
        Assert.AreEqual(0, HelperClass.Percent(EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram),
                                    UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram)), 0.00042);

        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
    }

    [TestMethod]
    public void Sub()
    {
        UnitsNet.SpecificEnergy UnitNet1 = new(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
        UnitsNet.SpecificEnergy UnitNet2 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

        EngineeringUnits.SpecificEnergy EngineeringUnits1 = new(1, SpecificEnergyUnit.BtuPerPound);
        EngineeringUnits.SpecificEnergy EngineeringUnits2 = new(10, SpecificEnergyUnit.JoulePerKilogram);

        UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 - UnitNet2;
        EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 - EngineeringUnits2;

        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
    }

    [TestMethod]
    public void SubSJON()
    {
        UnitsNet.SpecificEnergy UnitNet1 = new(1, UnitsNet.Units.SpecificEnergyUnit.BtuPerPound);
        UnitsNet.SpecificEnergy UnitNet2 = new(10, UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram);

        EngineeringUnits.SpecificEnergy EngineeringUnits1 = new(1, SpecificEnergyUnit.BtuPerPound);
        EngineeringUnits.SpecificEnergy EngineeringUnits2 = new(10, SpecificEnergyUnit.JoulePerKilogram);

        var jsonstring = JsonConvert.SerializeObject(EngineeringUnits2);
        EngineeringUnits.SpecificEnergy? JSON = JsonConvert.DeserializeObject<EngineeringUnits.SpecificEnergy>(jsonstring);

        UnitsNet.SpecificEnergy UnitNet3 = UnitNet1 - UnitNet2;
        EngineeringUnits.SpecificEnergy EngineeringUnits3 = EngineeringUnits1 - JSON;

        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.BtuPerPound) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.BtuPerPound), 1.7E-08);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.JoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.JoulePerKilogram), 0.01);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.CaloriePerGram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.CaloriePerGram), 2.2E-06);
        Assert.AreEqual(0, EngineeringUnits3.As(SpecificEnergyUnit.KilojoulePerKilogram) - UnitNet3.As(UnitsNet.Units.SpecificEnergyUnit.KilojoulePerKilogram), 9.07E-06);
    }
}
