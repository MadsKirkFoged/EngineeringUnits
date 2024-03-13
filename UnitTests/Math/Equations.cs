using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Linq;

namespace UnitTests;

[TestClass]
public class Equations
{

    [TestMethod]
    public void Powerequation()
    {

        //Q = m * Cp * dT

        //obs - UnitsNet cant do this eq..

        EngineeringUnits.SpecificEntropy P1 = new(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
        EngineeringUnits.MassFlow M1 = new(1, MassFlowUnit.KilogramPerSecond);
        EngineeringUnits.Temperature T2 = new(10, TemperatureUnit.DegreeCelsius);
        EngineeringUnits.Temperature T1 = new(5, TemperatureUnit.DegreeCelsius);

        EngineeringUnits.Power Q1 = M1 * P1 * (T2 - T1);

        UnitsNet.SpecificEntropy p1 = new(1, UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin);
        UnitsNet.MassFlow m1 = new(1, UnitsNet.Units.MassFlowUnit.KilogramPerSecond);
        UnitsNet.Temperature t2 = new(10, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
        UnitsNet.Temperature t1 = new(5, UnitsNet.Units.TemperatureUnit.DegreeCelsius);

        var q1 = UnitsNet.Power.FromWatts(p1.JoulesPerKilogramKelvin * m1.KilogramsPerSecond * (t2.Kelvins - t1.Kelvins));

        Assert.AreEqual(0, Q1.As(PowerUnit.BritishThermalUnitPerHour) - q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 7.2E-05);
        Assert.AreEqual(0, Q1.As(PowerUnit.Kilowatt) - q1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
        Assert.AreEqual(0, Q1.As(PowerUnit.Watt) - q1.As(UnitsNet.Units.PowerUnit.Watt), 0);

    }

    [TestMethod]
    public void Powerequation2()
    {

        //Q = m * Cp * dT

        //obs - UnitsNet cant do this eq..

        EngineeringUnits.SpecificEntropy P1 = new(35345, SpecificEntropyUnit.BtuPerPoundRankine);
        EngineeringUnits.MassFlow M1 = new(4356, MassFlowUnit.PoundPerMinute);
        EngineeringUnits.Temperature T2 = new(342, TemperatureUnit.DegreeRankine);
        EngineeringUnits.Temperature T1 = new(43, TemperatureUnit.DegreeRankine);

        EngineeringUnits.Power Q1 = M1 * P1 * (T2 - T1);

        UnitsNet.SpecificEntropy p1 = new(35345, UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit);
        UnitsNet.MassFlow m1 = new(4356, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
        UnitsNet.Temperature t2 = new(342, UnitsNet.Units.TemperatureUnit.DegreeRankine);
        UnitsNet.Temperature t1 = new(43, UnitsNet.Units.TemperatureUnit.DegreeRankine);

        var q1 = UnitsNet.Power.FromWatts(p1.JoulesPerKilogramKelvin * m1.KilogramsPerSecond * (t2.Kelvins - t1.Kelvins));

        //BtuPerPoundFahrenheit-- > JoulePerKilogramKelvin
        //UnitsNet: 4186,8
        //EngineeringUnits: 4186,816458133984
        //UnitsNet dont not use a high precision for this conversion which gives a off result

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(P1.As(SpecificEntropyUnit.JoulePerKilogramKelvin),
                                                p1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)), 0.0004);

        Assert.AreEqual(0, HelperClass.Percent(P1.As(SpecificEntropyUnit.BtuPerPoundRankine),
                                                p1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit)), 0);

        Assert.AreEqual(0, HelperClass.Percent(M1.As(MassFlowUnit.KilogramPerSecond),
                                                m1.As(UnitsNet.Units.MassFlowUnit.KilogramPerSecond)), 0.0003);

        //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.BritishThermalUnitPerHour) - q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour), 0);
        //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Kilowatt) - q1.As(UnitsNet.Units.PowerUnit.Kilowatt), 0);
        //Assert.AreEqual(0, Q1.As(EngineeringUnits.PowerUnit.Watt) - q1.As(UnitsNet.Units.PowerUnit.Watt), 0);

        //Difference in procent
        Assert.AreEqual(0, HelperClass.Percent(Q1.As(PowerUnit.BritishThermalUnitPerHour),
                                                q1.As(UnitsNet.Units.PowerUnit.BritishThermalUnitPerHour)), 0.0003);

        Assert.AreEqual(0, HelperClass.Percent(Q1.As(PowerUnit.Kilowatt),
                                                q1.As(UnitsNet.Units.PowerUnit.Kilowatt)), 0.00013);

        Assert.AreEqual(0, HelperClass.Percent(Q1.As(PowerUnit.Watt),
                                                q1.As(UnitsNet.Units.PowerUnit.Watt)), 0.00013);

        var jsonString1 = JsonConvert.SerializeObject(Q1);
        EngineeringUnits.Power? JSON = JsonConvert.DeserializeObject<EngineeringUnits.Power>(jsonString1);
        var jsonString2 = JsonConvert.SerializeObject(JSON);

        Assert.AreEqual(jsonString1, jsonString2);

    }

    [TestMethod]
    public void ForceEquation()
    {
        var massU = new UnitsNet.Mass(36, UnitsNet.Units.MassUnit.Kilogram);
        var gU = new UnitsNet.Acceleration(1, UnitsNet.Units.AccelerationUnit.StandardGravity);
        var g2U = new UnitsNet.Acceleration(4.5, UnitsNet.Units.AccelerationUnit.MeterPerSecondSquared);

        var massE = new EngineeringUnits.Mass(36, MassUnit.Kilogram);
        var gE = new EngineeringUnits.Acceleration(1, AccelerationUnit.StandardGravity);
        var g2E = new EngineeringUnits.Acceleration(4.5, AccelerationUnit.MeterPerSecondSquared);

        UnitsNet.Force Result1 = massU * (gU + g2U);

        EngineeringUnits.Force Result2 = massE * (gE + g2E);

        var WorkingCompares = 0;

        foreach (ForceUnit EU in UnitTypebase.ListOf<ForceUnit>())
        {

            var RelError = 2E-3;

            System.Collections.Generic.IEnumerable<UnitsNet.Units.ForceUnit> UNList = UnitsNet.Force.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.ForceUnit UN = UNList.Single();

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                        Result1.As(UN)),
                                                        RelError);

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(15, WorkingCompares);

    }

    [TestMethod]
    public void SpecificEntropyEquation()
    {

        var massU = new UnitsNet.Mass(36, UnitsNet.Units.MassUnit.Kilogram);
        var EnergyU = new UnitsNet.Energy(1, UnitsNet.Units.EnergyUnit.Calorie);
        var TemperatureU = new UnitsNet.Temperature(4.5, UnitsNet.Units.TemperatureUnit.DegreeCelsius);

        var massE = new EngineeringUnits.Mass(36, MassUnit.Kilogram);
        var EnergyE = new EngineeringUnits.Energy(1, EnergyUnit.Calorie);
        var TemperatureE = new EngineeringUnits.Temperature(4.5, TemperatureUnit.DegreeCelsius);

        var Result1 = UnitsNet.SpecificEntropy.FromJoulesPerKilogramKelvin(EnergyU.Joules / (massU.Kilograms * TemperatureU.Kelvins));

        EngineeringUnits.SpecificEntropy Result2 = EnergyE / (massE * TemperatureE);

        var WorkingCompares = 0;

        foreach (SpecificEntropyUnit EU in UnitTypebase.ListOf<SpecificEntropyUnit>())
        {

            var RelError = 2E-3;

            System.Collections.Generic.IEnumerable<UnitsNet.Units.SpecificEntropyUnit> UNList = UnitsNet.SpecificEntropy.Units.Where(x => x.ToString() == EU.QuantityName);

            if (UNList.Count() == 1)
            {
                UnitsNet.Units.SpecificEntropyUnit UN = UNList.Single();

                //All units relative difference
                Assert.AreEqual(0, HelperClass.Percent(Result2.As(EU),
                                                        Result1.As(UN)),
                                                        RelError);

                WorkingCompares++;

            }
        }

        //Number of comparables units
        Assert.AreEqual(9, WorkingCompares);

    }
}
