using EngineeringUnits.Fast;
using EngineeringUnits.Units.Fast;

namespace UnitTests.Fast;

/// <summary>
/// Everyday engineering calculations with answers you can check on a calculator.
/// The same scenarios as EverydayMistakesTests in the analyzer tests - there the units are checked, here the numbers.
/// </summary>
[TestClass]
public class EverydayCalculationsTests
{
    [TestMethod]
    public void Heater_2kW_For3Hours_Uses6kWh()
    {
        Energy used = Power.FromKilowatt(2) * Duration.FromHour(3);

        Assert.AreEqual(6, used.KilowattHour, 1e-12);
        Assert.AreEqual("6 kWh", used.ToString(EnergyUnit.KilowattHour));
    }

    [TestMethod]
    public void HeatingWater_0_1kgPerSecond_By25K_Takes10_45kW()
    {
        MassFlow water = MassFlow.FromKilogramPerSecond(0.1);
        SpecificEntropy heatCapacity = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        Temperature inlet = Temperature.FromDegreeCelsius(10), outlet = Temperature.FromDegreeCelsius(35);

        Power heat = water * heatCapacity * (outlet - inlet);

        Assert.AreEqual(10.45, heat.Kilowatt, 1e-12);                 // 0.1 × 4180 × 25 = 10 450 W
        Assert.AreEqual("10.45 kW", heat.ToString(PowerUnit.Kilowatt));
    }

    [TestMethod]
    public void Car_100km_In1Hour15_Is80kmh()
    {
        Speed average = Length.FromKilometer(100) / Duration.FromHour(1.25);
        Assert.AreEqual(80, average.KilometerPerHour, 1e-12);
    }

    [TestMethod]
    public void Car_1Tonne_At72kmh_Has200kJ()
    {
        Mass car = Mass.FromTonne(1);
        Speed velocity = Speed.FromKilometerPerHour(72);               // = 20 m/s

        Energy kinetic = 0.5 * car * velocity * velocity;               // ½ × 1000 × 20²
        Speed back = (2 * kinetic / car).Sqrt();

        Assert.AreEqual(200, kinetic.Kilojoule, 1e-9);
        Assert.AreEqual(72, back.KilometerPerHour, 1e-9);
    }

    [TestMethod]
    public void Electrical_2A_Through115Ohm_Is230V_And460W()
    {
        ElectricCurrent current = ElectricCurrent.FromAmpere(2);
        ElectricPotential voltage = current * ElectricResistance.FromOhm(115);
        Power consumed = voltage * current;

        Assert.AreEqual(230, voltage.Volt, 1e-12);
        Assert.AreEqual(460, consumed.Watt, 1e-12);
    }

    [TestMethod]
    public void Pump_36m3PerHour_Against2Bar_Needs2kW()
    {
        Power hydraulic = VolumeFlow.FromCubicMeterPerHour(36) * Pressure.FromBar(2);   // 0.01 m³/s × 200 000 Pa
        Assert.AreEqual(2, hydraulic.Kilowatt, 1e-12);
    }

    [TestMethod]
    public void Pipe_VelocityAndReynoldsNumber()
    {
        Speed velocity = VolumeFlow.FromCubicMeterPerSecond(0.01) / Area.FromSquareMeter(0.005);
        double reynolds = (double)(Density.FromKilogramPerCubicMeter(998) * velocity * Length.FromMillimeter(80) / DynamicViscosity.FromCentipoise(1));

        Assert.AreEqual(2, velocity.MeterPerSecond, 1e-12);
        Assert.AreEqual(159_680, reynolds, 1e-6);                       // 998 × 2 × 0.08 / 0.001
    }

    [TestMethod]
    public void Wall_20m2_WithU0_3_At25K_Loses150W()
    {
        Power loss = HeatTransferCoefficient.FromWattPerSquareMeterKelvin(0.3) * Area.FromSquareMeter(20)
                   * (Temperature.FromDegreeCelsius(20) - Temperature.FromDegreeCelsius(-5));
        Assert.AreEqual(150, loss.Watt, 1e-12);
    }

    [TestMethod]
    public void ElectricityBill_6kWh_At25Cents_Is1_50Dollar()
    {
        Cost bill = Energy.FromKilowattHour(6) * EnergyCost.FromUSDollarPerKilowattHour(0.25);
        Assert.AreEqual(1.5, bill.USDollar, 1e-12);
    }

    [TestMethod]
    public void Density_10kg_In4m3_Is2_5()
    {
        Density d = Mass.FromKilogram(10) / Volume.FromCubicMeter(4);
        Assert.AreEqual(2.5, d.KilogramPerCubicMeter, 1e-15);
    }

    [TestMethod]
    public void Weight_75kg_Is735N()
    {
        Force weight = Mass.FromKilogram(75) * Constants.StandardGravity;
        Assert.AreEqual(735.49875, weight.Newton, 1e-9);                // 75 × 9.80665
    }

    [TestMethod]
    public void Pressure_1000N_On0_5m2_Is2000Pa()
    {
        Pressure p = Force.FromNewton(1000) / Area.FromSquareMeter(0.5);
        Assert.AreEqual(2000, p.Pascal, 1e-12);
        Assert.AreEqual(0.02, p.Bar, 1e-15);
    }

    [TestMethod]
    public void Battery_100Ah_At12V_Stores1_2kWh()
    {
        Energy stored = ElectricCharge.FromAmpereHour(100) * ElectricPotential.FromVolt(12);
        Assert.AreEqual(1.2, stored.KilowattHour, 1e-12);
    }

    [TestMethod]
    public void Solar_800WPerM2_On1_6m2_At20Percent_Gives256W()
    {
        Power output = Irradiance.FromWattPerSquareMeter(800) * Area.FromSquareMeter(1.6) * Ratio.FromPercent(20);
        Assert.AreEqual(256, output.Watt, 1e-9);
    }

    [TestMethod]
    public void Motor_50Nm_At150RadPerSecond_Is7_5kW()
    {
        Power shaft = Torque.FromNewtonMeter(50) * RotationalSpeed.FromRadianPerSecond(150);
        Assert.AreEqual(7.5, shaft.Kilowatt, 1e-12);
    }

    [TestMethod]
    public void Battery_10kWh_OverNight_CantCover3kW()
    {
        Power available = Energy.FromKilowattHour(10) / Duration.FromHour(8);
        Power demand = Power.FromKilowatt(3);

        Assert.AreEqual(1.25, available.Kilowatt, 1e-12);
        Assert.IsTrue(available < demand);
    }

    [TestMethod]
    public void Week_OfDailyUse_SumsAndAverages()
    {
        // power × time is an UnknownUnit - say what it is, (Energy)(...), and the analyzer checks that it really is energy.
        // Without the cast you get a List<UnknownUnit>, which has no Sum(): collections of UnknownUnit are not tracked.
        var days = Enumerable.Range(1, 7).Select(day => (Energy)(Power.FromKilowatt(day) * Duration.FromHour(1))).ToList();   // 1..7 kWh

        Assert.AreEqual(28, days.Sum().KilowattHour, 1e-12);
        Assert.AreEqual(4, days.Average().KilowattHour, 1e-12);
        Assert.AreEqual(7, days.Max().KilowattHour, 1e-12);
    }

    [TestMethod]
    public void Conversions_EveryoneKnows()
    {
        Assert.AreEqual(1609.344, Length.FromMile(1).Meter, 1e-9);
        Assert.AreEqual(12, Length.FromFoot(1).Inch, 1e-12);
        Assert.AreEqual(212, Temperature.FromDegreeCelsius(100).DegreeFahrenheit, 1e-9);
        Assert.AreEqual(32, Temperature.FromDegreeCelsius(0).DegreeFahrenheit, 1e-9);
        Assert.AreEqual(-40, Temperature.FromDegreeFahrenheit(-40).DegreeCelsius, 1e-9);
        Assert.AreEqual(14.5037738, Pressure.FromBar(1).PoundForcePerSquareInch, 1e-7);
        Assert.AreEqual(735.49875, Power.FromMetricHorsepower(1).Watt, 1e-9);
        Assert.AreEqual(3.6, Energy.FromKilowattHour(1).Megajoule, 1e-12);
        Assert.AreEqual(1000, Volume.FromCubicMeter(1).Liter, 1e-9);
    }

    /// <summary>
    /// 1 mechanical horsepower = 550 ft·lbf/s = 745.69987158227022 W exactly.
    /// EngineeringUnits defines it as 745.69 (PowerEnum.cs), and Fast is generated from that. Remove [Ignore] after fixing
    /// the original and re-running CodeGen.Fast.
    /// </summary>
    [TestMethod]
    [Ignore("Bug in EngineeringUnits: PowerUnit.MechanicalHorsepower is 745.69 instead of 745.69987158227022")]
    public void MechanicalHorsepower_Is550FootPoundForcePerSecond()
    {
        Assert.AreEqual(745.69987158227022, Power.FromMechanicalHorsepower(1).Watt, 1e-9);
    }

    [TestMethod]
    public void Temperature_20C_Plus5K_Is25C()
    {
        Temperature warmer = Temperature.FromDegreeCelsius(20) + Temperature.FromKelvin(5);
        Assert.AreEqual(25, warmer.DegreeCelsius, 1e-12);
    }
}
