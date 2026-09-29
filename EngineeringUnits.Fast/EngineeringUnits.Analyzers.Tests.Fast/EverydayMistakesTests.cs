using static EngineeringUnits.Analyzers.Tests.Fast.AnalyzerVerifier;

namespace EngineeringUnits.Analyzers.Tests.Fast;

/// <summary>
/// Everyday engineering code, and the mistakes people really make in it.
///
/// How to read these: every line must compile cleanly, EXCEPT the parts marked {|EUF0001:like this|}.
/// A marked part must give exactly that error, at exactly that spot. If the analyzer misses a mistake, or complains about
/// correct code, the test fails.
/// </summary>
[TestClass]
public class EverydayMistakesTests
{
    [TestMethod]
    public Task Heater_EnergyIsPowerTimesTime() => VerifyBodyAsync("""
        Power heater = Power.FromKilowatt(2);
        Duration running = Duration.FromHour(3);

        Energy used = heater * running;                      // ✔ 6 kWh
        Energy wrong = {|EUF0001:heater / running|};             // ✘ divided instead of multiplied
        """);

    [TestMethod]
    public Task Pump_HydraulicPowerIsFlowTimesPressure() => VerifyBodyAsync("""
        VolumeFlow flow = VolumeFlow.FromCubicMeterPerHour(36);
        Pressure lift = Pressure.FromBar(2);

        Power hydraulic = flow * lift;                       // ✔ m³/s × Pa = W
        Power wrong = {|EUF0001:flow / lift|};                   // ✘ divided
        """);

    [TestMethod]
    public Task HeatingWater_ForgettingTheTemperatureDifference() => VerifyBodyAsync("""
        MassFlow water = MassFlow.FromKilogramPerSecond(0.1);
        SpecificEntropy heatCapacity = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        Temperature inlet = Temperature.FromDegreeCelsius(10);
        Temperature outlet = Temperature.FromDegreeCelsius(35);

        Power heat = water * heatCapacity * (outlet - inlet);   // ✔ 10.45 kW
        Power forgotDeltaT = {|EUF0001:water * heatCapacity|};      // ✘ that is W/K, not W
        """);

    [TestMethod]
    public Task Car_SpeedIsDistanceOverTime() => VerifyBodyAsync("""
        Length trip = Length.FromKilometer(100);
        Duration driving = Duration.FromHour(1.25);

        Speed average = trip / driving;                      // ✔ 80 km/h
        Speed upsideDown = {|EUF0001:driving / trip|};           // ✘ time per distance
        """);

    [TestMethod]
    public Task Car_KineticEnergyNeedsSpeedSquared() => VerifyBodyAsync("""
        Mass car = Mass.FromTonne(1);
        Speed velocity = Speed.FromKilometerPerHour(72);

        Energy kinetic = 0.5 * car * velocity * velocity;    // ✔ ½·m·v²
        Energy kineticToo = 0.5 * car * velocity.Pow(2);     // ✔ same with Pow
        Energy forgotSquare = {|EUF0001:0.5 * car * velocity|};  // ✘ that is momentum
        """);

    [TestMethod]
    public Task Electrical_OhmsLawAndPower() => VerifyBodyAsync("""
        ElectricCurrent current = ElectricCurrent.FromAmpere(2);
        ElectricResistance resistor = ElectricResistance.FromOhm(115);

        ElectricPotential voltage = current * resistor;      // ✔ U = I·R = 230 V
        Power consumed = voltage * current;                  // ✔ P = U·I = 460 W
        Power wrong = {|EUF0001:voltage / current|};             // ✘ that is a resistance
        """);

    [TestMethod]
    public Task Density_MassOverVolume() => VerifyBodyAsync("""
        Mass sand = Mass.FromKilogram(10);
        Volume bucket = Volume.FromCubicMeter(4);

        Density d1 = sand / bucket;                          // ✔ kg/m³ (from the EngineeringUnits README)
        Density d2 = {|EUF0001:bucket / sand|};                  // ✘ upside down
        """);

    [TestMethod]
    public Task Pressure_ForceOverArea() => VerifyBodyAsync("""
        Force push = Force.FromNewton(1000);
        Area piston = Area.FromSquareMeter(0.5);

        Pressure p = push / piston;                          // ✔ 2000 Pa
        Pressure wrong = {|EUF0001:push * piston|};              // ✘ multiplied
        """);

    [TestMethod]
    public Task Wall_HeatLossNeedsTheArea() => VerifyBodyAsync("""
        HeatTransferCoefficient uValue = HeatTransferCoefficient.FromWattPerSquareMeterKelvin(0.3);
        Area wall = Area.FromSquareMeter(20);
        Temperature inside = Temperature.FromDegreeCelsius(20), outside = Temperature.FromDegreeCelsius(-5);

        Power loss = uValue * wall * (inside - outside);     // ✔ 150 W
        Power forgotArea = {|EUF0001:uValue * (inside - outside)|};  // ✘ that is W/m²
        """);

    [TestMethod]
    public Task Pipe_VelocityIsFlowOverArea() => VerifyBodyAsync("""
        VolumeFlow flow = VolumeFlow.FromCubicMeterPerSecond(0.01);
        Area pipe = Area.FromSquareMeter(0.005);

        Speed velocity = flow / pipe;                        // ✔ 2 m/s
        Speed wrong = {|EUF0001:flow * pipe|};                   // ✘ multiplied
        """);

    [TestMethod]
    public Task Pipe_ReynoldsNumberHasNoUnit() => VerifyBodyAsync("""
        Density water = Density.FromKilogramPerCubicMeter(998);
        Speed velocity = Speed.FromMeterPerSecond(2);
        Length diameter = Length.FromMillimeter(80);
        DynamicViscosity viscosity = DynamicViscosity.FromCentipoise(1);

        double reynolds = (double)(water * velocity * diameter / viscosity);     // ✔ dimensionless
        double forgotDensity = {|EUF0004:(double)(velocity * diameter / viscosity)|};  // ✘ still has a unit
        """);

    [TestMethod]
    public Task Weight_MassTimesGravity() => VerifyBodyAsync("""
        Mass person = Mass.FromKilogram(75);

        Force weight = person * Constants.StandardGravity;   // ✔ 735 N
        Force wrong = {|EUF0001:person * Speed.FromMeterPerSecond(9.81)|};  // ✘ m/s is not m/s²
        """);

    [TestMethod]
    public Task Battery_ChargeTimesVoltage() => VerifyBodyAsync("""
        ElectricCharge capacity = ElectricCharge.FromAmpereHour(100);
        ElectricPotential nominal = ElectricPotential.FromVolt(12);

        Energy stored = capacity * nominal;                  // ✔ 1.2 kWh
        Energy wrong = {|EUF0001:capacity / nominal|};           // ✘ divided
        """);

    [TestMethod]
    public Task Solar_IrradianceTimesAreaTimesEfficiency() => VerifyBodyAsync("""
        Irradiance sun = Irradiance.FromWattPerSquareMeter(800);
        Area panel = Area.FromSquareMeter(1.6);
        Ratio efficiency = Ratio.FromPercent(20);

        Power output = sun * panel * efficiency;             // ✔ a ratio has no unit
        Power forgotArea = {|EUF0001:sun * efficiency|};         // ✘ still W/m²
        """);

    [TestMethod]
    public Task ElectricityBill_EnergyTimesPrice() => VerifyBodyAsync("""
        Energy used = Energy.FromKilowattHour(6);
        EnergyCost price = EnergyCost.FromUSDollarPerKilowattHour(0.25);
        Power heater = Power.FromKilowatt(2);

        Cost bill = used * price;                            // ✔ $1.50
        Cost wrong = {|EUF0001:heater * price|};                 // ✘ forgot how long it ran
        """);

    [TestMethod]
    public Task Motor_ShaftPowerIsTorqueTimesAngularSpeed() => VerifyBodyAsync("""
        Torque torque = Torque.FromNewtonMeter(50);
        RotationalSpeed shaft = RotationalSpeed.FromRadianPerSecond(150);

        Power shaftPower = torque * shaft;                   // ✔ 7.5 kW
        Power wrong = {|EUF0001:torque / shaft|};                // ✘ divided
        """);

    [TestMethod]
    public Task Adding_OnlyTheSameKindOfThing() => VerifyBodyAsync("""
        Energy stored = Energy.FromKilojoule(500);
        Power charger = Power.FromKilowatt(1);
        Duration charging = Duration.FromMinute(10);

        Energy total = stored + charger * charging;          // ✔ energy + energy
        Energy wrong = {|EUF0002:stored + charger / charging|};  // ✘ energy + W/s
        """);

    [TestMethod]
    public Task RunningTotal_WithPlusEquals() => VerifyBodyAsync("""
        Power heater = Power.FromKilowatt(2);
        Duration step = Duration.FromMinute(15);

        Ratio dutyCycle = Ratio.FromPercent(50);

        Energy total = Energy.Zero;
        total += heater * step;                              // ✔ add energy
        total += heater * dutyCycle * step;                  // ✔ still energy
        {|EUF0002:total += heater * dutyCycle|};                 // ✘ added power, forgot the time step
        """);

    [TestMethod]
    public void RunningTotal_AddingPowerDirectly_DoesNotEvenCompile()
        => VerifyCompileError("Energy total = Energy.Zero; total += Power.FromKilowatt(2);", "CS0034", "CS9342");

    [TestMethod]
    public Task Comparing_OnlyTheSameKindOfThing() => VerifyBodyAsync("""
        Power demand = Power.FromKilowatt(3);
        Energy battery = Energy.FromKilowattHour(10);
        Duration night = Duration.FromHour(8);

        bool enough = battery / night > demand;              // ✔ power vs power
        bool wrong = {|EUF0003:battery > demand * 1.0 / night|}; // ✘ energy vs W/s
        """);

    [TestMethod]
    public Task Var_IntermediateResultsAreTracked() => VerifyBodyAsync("""
        MassFlow water = MassFlow.FromKilogramPerSecond(0.1);
        SpecificEntropy heatCapacity = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        Temperature inlet = Temperature.FromDegreeCelsius(10), outlet = Temperature.FromDegreeCelsius(35);

        var heatPerKelvin = water * heatCapacity;            // W/K - the analyzer remembers
        var deltaT = outlet - inlet;
        Power heat = heatPerKelvin * deltaT;                 // ✔
        Power wrong = {|EUF0001:heatPerKelvin|};                 // ✘ W/K is not W
        """);

    [TestMethod]
    public Task Efficiency_OnlyUnitlessValuesBecomeNumbers() => VerifyBodyAsync("""
        Power input = Power.FromKilowatt(10);
        Power output = Power.FromKilowatt(8.5);
        Duration hour = Duration.FromHour(1);

        double efficiency = (double)(output / input);        // ✔ 0.85
        double wrong = {|EUF0004:(double)(output / hour)|};      // ✘ W/s is not a plain number
        """);

    [TestMethod]
    public Task SquareRoot_OnlyWhenTheUnitAllowsIt() => VerifyBodyAsync("""
        Energy kinetic = Energy.FromKilojoule(200);
        Mass car = Mass.FromTonne(1);

        Speed velocity = (2 * kinetic / car).Sqrt();         // ✔ √(2E/m) = 20 m/s
        var wrong = {|EUF0006:kinetic.Sqrt()|};                  // ✘ √J has half a kilogram in it
        """);

    [TestMethod]
    public void Adding_DifferentThings_DoesNotEvenCompile()
    {
        // No analyzer needed: C# itself refuses these
        VerifyCompileError("var x = Length.FromMeter(1) + Duration.FromSecond(1);", "CS0034", "CS9342");
        VerifyCompileError("var x = Mass.FromKilogram(1) == Volume.FromLiter(1);", "CS0034", "CS9342", "CS0019");
        VerifyCompileError("Power p = 5;", "CS0029");
        VerifyCompileError("double d = Power.FromWatt(5);", "CS0029");
    }

    [TestMethod]
    public Task StoringAnUnknownInAField_MustSayWhatItIs() => VerifyAsync("""
        using EngineeringUnits.Fast;

        public class Boiler
        {
            private UnknownUnit _heatPerKelvin;                                 // no unit written down anywhere

            [UnitDimension(BaseunitType.mass, 1, BaseunitType.length, 2, BaseunitType.time, -3, BaseunitType.temperature, -1)]
            private UnknownUnit _conductance;                                   // unit written down: W/K

            public void Configure(MassFlow m, SpecificEntropy cp)
            {
                _heatPerKelvin = m * cp;
                _conductance = m * cp;                                      // ✔ checked against W/K
            }

            public Power HeatA(Temperature dT) => {|EUF0007:_heatPerKelvin * dT|};  // ✘ can't be verified
            public Power HeatB(Temperature dT) => _conductance * dT;              // ✔
        }
        """);
}

/// <summary>
/// Honest limits: these are real mistakes, but the units add up, so NO analyzer can see them. The same is true for
/// EngineeringUnits. These tests pass when there is no diagnostic - they document what you still have to check yourself.
/// </summary>
[TestClass]
public class WhatTheAnalyzerCannotCatch
{
    [TestMethod]
    public Task AbsoluteTemperatureInsteadOfDifference() => VerifyBodyAsync("""
        MassFlow water = MassFlow.FromKilogramPerSecond(0.1);
        SpecificEntropy heatCapacity = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        Temperature outlet = Temperature.FromDegreeCelsius(35);

        Power heat = water * heatCapacity * outlet;          // compiles: K is K, but you meant (outlet - inlet)
        """);

    [TestMethod]
    public Task TorqueAndEnergyHaveTheSameUnit() => VerifyBodyAsync("""
        Force force = Force.FromNewton(100);
        Length arm = Length.FromMeter(0.5);

        Torque torque = force * arm;                         // N·m
        Energy work = force * arm;                           // also N·m (= J) - the units can't tell them apart
        """);

    [TestMethod]
    public Task WrongNumberInTheRightUnit() => VerifyBodyAsync("""
        Power heater = Power.FromKilowatt(2000);             // you meant 2000 W - units can't check the number
        """);

    [TestMethod]
    public Task ForgettingAUnitlessFactor() => VerifyBodyAsync("""
        Irradiance sun = Irradiance.FromWattPerSquareMeter(800);
        Area panel = Area.FromSquareMeter(1.6);

        Power output = sun * panel;                          // forgot "* efficiency" - a ratio has no unit
        """);
}
