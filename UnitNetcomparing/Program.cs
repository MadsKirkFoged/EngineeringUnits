using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics.Metrics;
//using UnitsNet;

namespace Sandbox;

public class Program
{
    public static readonly Power P1 = Power.FromSI(10);
    public static readonly Length L1 = Length.FromSI(2);
    public static readonly Temperature T1 = Temperature.FromSI(4);

    //private static async Task<MassFlow> TestFucntion()
    //{

    //    var massFlow = new MassFlow(10, MassFlowUnit.KilogramPerSecond);
    //    MassFlow massFlow1 = (massFlow * 0.1) + massFlow;

    //    var test = massFlow1.As(massFlow);

    //    var m1 = new Mass(1, MassUnit.Kilogram);
    //    var d1 = new Duration(12, DurationUnit.Second);

    //    MassFlow m3 = m1 / d1;

    //    massFlow1 += m3;

    //    await Task.Delay(0);

    //    return massFlow1;
    //}

    public static void Main()
    {

        Length L2 = new Length(1, LengthUnit.Mile);



        var testtt = (MassFlow.FromCentigramPerDay(1), MassFlow.FromDecagramPerSecond(1)).Sum();

       

        //var tupletest = (MassFlow.Zero, MassFlow.Zero).Max();




        //var InfTest = MassFlow.FromKilogramPerSecond(1) / MassFlow.Zero;

        //MassFlow massFlow3 = MassFlow.FromKilogramPerSecond(1) + InfTest;


        //string NaNTest2 = InfTest.ToString();

        //List<int> mynewlist = new List<int> { 1, 1, 1, 2, 4, 6, 6, 8 };

        //mynewlist.Sum();


        //int ii = 0;


        //decimal d1 = ii;  

        //double positive = -10;

        //double negative = +positive;

        //Math.Clamp(positive, 0, 100);

        //Math.Min(positive, 100);
        //Math.Max(positive, 100);

        //var l1 = Length.FromMeter(1);
        //var l2 = Length.FromMeter(1);

        //var l3 = (l1 + l2).LowerLimitAt(Length.FromMeter(5));

        ////var length = (Length.FromMeter(1) + Length.FromMeter(1)).LowerLimitAt(Length.FromMeter(5));

        ////Length lengthmin1 = lengthmin * lengthmin;

        ////var test = lengthmin.Minimum(lengthmin);


        //MassFlow Min2 = UnitMath.Min(MassFlow.FromKilogramPerSecond(1),
        //                             MassFlow.FromKilogramPerSecond(2));


        //var h1 = new Enthalpy(10, EnthalpyUnit.JoulePerKilogram);
        //var h2 = new Enthalpy(100, EnthalpyUnit.JoulePerKilogram);
        //var m1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);



        //UnknownUnit p11 = (m1 * (h2 - h1));


        ////var p1 = Pressure.FromBar(10);
        ////var p2 = Pressure.FromBar(20);





        ////Console.WriteLine($"{nameof(p1)}: {p1}"); // prints "p1: 10 bar"
        ////Console.WriteLine($"{nameof(p2)}: {p2}"); // prints "p2: 20 bar"
        ////Console.WriteLine($"p1.Minimum(p2): {p1.Minimum(p2)}"); // prints "p1.Minimum(p2): 20 bar"
        ////Console.WriteLine($"p2.Minimum(p1): {p2.Minimum(p1)}"); // prints "p2.Minimum(p1): 20 bar"
        ////Console.WriteLine($"p1.Maximum(p2): {p1.Maximum(p2)}"); // prints "p1.Maximum(p2): 10 bar"
        ////Console.WriteLine($"p2.Maximum(p1): {p2.Maximum(p1)}"); // prints "p2.Maximum(p1): 10 bar"



        //List<int> numbers = new List<int> { 1, 1, 1, 2, 4, 6, 6, 8 };

        //var result = numbers
        //            .GroupBy(n => n)
        //            .Where(group => group.Count() > 1)
        //            .SelectMany(group => Enumerable.Repeat(group.Key, group.Count()));


        //foreach (var sum in result)
        //{
        //    Console.Write($"{sum}; ");
        //}


        //double d = 0.00000000000;


        //double? aa = d;


        //Power PZero = Power.Zero;


        //var PZero2 = PZero.Kilowatt;


        ////var ppp = 1/0.000295299830714159m;

        //var ppp2 = new Fraction(1000000000000000000, 295299830714159);

        //var ppp3 = ppp2.ToDecimal();

        ////Temperature L1 = Temperature.FromDegreesCelsius(0);
        ////Temperature L2 = Temperature.FromDegreesFahrenheit(32);

        //Console.WriteLine($"{Length.FromMeter(0) == Length.FromKilometer(0)}"); //True
        //Console.WriteLine($"{Length.FromMeter(1000) == Length.FromKilometer(1)}"); //True
        //Console.WriteLine($"{Temperature.FromDegreesCelsius(0) == Temperature.FromKelvins(0)}"); //false
        //Console.WriteLine($"{Temperature.FromDegreesCelsius(0) == Temperature.FromDegreesFahrenheit(32)}"); //True
        //Console.WriteLine($"{Length.FromFoot(3) == Length.FromYard(1)}"); //True

        //UnitSystem unitt = TemperatureUnit.DegreeFahrenheit;


        //var TT = Temperature.FromDegreesFahrenheit(32);


        //var nantest = new Mass(double.NaN, MassUnit.SI).SI;

        //var nantest2 =  Mass.FromCentigram(double.NaN).Grain;


        //var jerk1 = new Jerk(10, JerkUnit.MeterPerSecondCubed);
        //var jerk2 = Jerk.FromCentimeterPerSecondCubed(10);
        //var jerk3 = Length.FromMeter(2) / Duration.FromSecond(10).Pow(3);

        //var jerk4 = jerk1 + jerk2 +jerk3;



        //var specificEnergy1 = SpecificEnergy.FromJoulePerKilogram(1000);
        //var specificEnergy2 = SpecificEnergy.FromJoulePerKilogram(2000);


        //MassFlow massflow0 = Power.FromKilowatt(100) / (specificEnergy2- specificEnergy1);

        //var teste = massflow0.ToString();


        //var massflow1 = new MassFlow(1, MassFlowUnit.SI);

        //var massflow2 = MassFlow.FromKilogramPerSecond(1);

        //var mass1 = new Mass(1, MassUnit.Kilogram);
        //var duration1 = new Duration(1, DurationUnit.SI);

        //MassFlow massflow3 = mass1/duration1;

        //UnitSystem unit = MassUnit.Gram.Unit;
        //var valueWithUnit = new BaseUnit(1, unit);

        ////var before = valueWithUnit.GetValueAs(unit);

        //for (var i = 0; i < 2; i++)
        //{
        //    UnitSystem siUnit = unit.GetSIUnitsystem();

        //    var test = siUnit.ToString();

        //    var convertedValue = valueWithUnit.As(siUnit);
        //    var value = new UnknownUnit(convertedValue, unit);
        //}

        //var after = valueWithUnit.As(unit);

        //var converterror = new SpecificEnergy(10, SpecificEnergyUnit.SI);

        //converterror = null;

        //Enthalpy enthalpy = converterror;

        ////for (var i = 0; i < 10000000; i++)
        ////    UnknownUnit speedtest = P1 / (L1 * T1);

        ////var MyList = new List<Mass>
        ////{
        ////    Mass.FromKilogram(43),
        ////    Mass.FromMegapound(2),
        ////    Mass.FromMilligram(77644),
        ////    Mass.FromPound(345)
        ////};

        ////Mass Min = MyList.Min();    //7.764e+04 mg
        ////Mass Max = MyList.Max();    //2 Mlb
        //Mass Avg = MyList.Average(); //2.268e+05 kg
        //Mass Sum = MyList.Sum();     //9.074e+05 kg
        //Mass Mean = MyList.Mean();     //345 lb

        ////Create new unit
        //Length L11 = new(1d, LengthUnit.Meter);

        ////Serialize it into JSON 
        //var L1AsJSON = JsonConvert.SerializeObject(L11);

        ////Deserialize from JSON
        //Length BackFromJSON = JsonConvert.DeserializeObject<Length>(L1AsJSON);

        //var PrintOut = $"";

        //var lllist = new List<string>();

        ////List<string> assembly = ListOfUnitsForDifferentGenerators.GetListOFAllUnits();

        ////List<string> assembly = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };

        ////assembly.Sort();

        ////foreach (var assemblyName in assembly)
        ////{
        ////    var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");
        ////    PrintOut += "\n"+assemblyName+":";
        ////    foreach (FieldInfo item in t.GetFields(BindingFlags.Static | BindingFlags.Public))

        ////        PrintOut+=$"[{item.Name}], ";
        ////}

        ////Length temp = valueOfT.AddUnit<LengthUnit>(unit);

        //var L111 = Length.FromMeter(10); //10m

        //Length L22 = L111.Minimum(Length.FromMeter(5)); //10m
        //Length L33 = L111.Minimum(Length.FromMeter(15)); //15m
        //Length L44 = L111.Maximum(Length.FromMeter(5)); //5m
        //Length L55 = L111.Maximum(Length.FromMeter(15)); //10m

        //var PressureTest = new Pressure(1, PressureUnit.Bar, PressureReference.Absolute);
        //var PressureTest2 = new Pressure(3, PressureUnit.Bar, PressureReference.Absolute);

        //Pressure PressureTest3 = PressureTest2 - PressureTest;

        //PressureTest = PressureTest.ToUnit(PressureReference.Gauge);

        //var Bara1 = $"{PressureTest:V4}";

        //var Bara2 = $"{PressureTest:UnitOnly}";

        ////var PressureTest2 = PressureTest.ToUnit(PressureUnit.Pascal);

        //var massflow = MassFlow.FromKilogramPerDay(1);

        ////UnknownUnit massflow2 = MassFlow.FromKilogramPerSecond(1) / 2;

        ////var DataTasks = new List<Task<MassFlow>>();
        ////for (int i = 0; i < 1000000000; i++)
        ////{

        ////    DataTasks.Add(TestFucntion());
        ////}

        ////var returntest = await Task.WhenAll(DataTasks);

        ////double? nulltest = null;

        ////UnknownUnit UnknownUnittest = new(nulltest);

        ////UnknownUnit nulltest = massFlow3;

        //MassFlow massFlow = new MassFlow(-10, MassFlowUnit.KilogramPerSecond).Abs();
        //var massFlow2 = new MassFlow(19, MassFlowUnit.KilogramPerSecond);
        //var booltest = massFlow == massFlow2;

        //MassFlow massFlow1 = massFlow * 0.1;

        //massFlow1 = massFlow * 0.1;

        //Temperature temperature2 = null;

        //if (temperature2 == null)
        //{

        //}

        //if (temperature2 is null)
        //{

        //}

        //if (temperature2 is not null)
        //{

        //}

        //var Mylist = new List<Power>();

        //Power nullcheck = Mylist.Max();
        //Power nullcheck2 = nullcheck?.ToUnit(PowerUnit.Watt);

        //var nullcheck3 = $"{nullcheck2}";

        //var Mole = new Volume(10, VolumeUnit.SI);
        //var Time = new Mass(5, MassUnit.SI);

        //SpecificVolume MF = Mole / Time;

        //var testmf = new MassFlow(10, MassFlowUnit.KilogramPerSecond);

        //var Text = PressureUnit.DynePerSquareCentimeter.ToString();

        ////finding similar units with different naming
        //var mylist = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Temperature", "Acceleration", "Angle", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance", "ApparentPower", "Enthalpy", "SpecificHeatCapacity" };
        //var list2 = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Temperature", "Acceleration", "Angle", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance", "ApparentPower", "Enthalpy", "SpecificHeatCapacity" };

        //var re = new List<string>();
        //UnitSystem alias1;
        //UnitSystem alias2;
        //foreach (var item in mylist)
        //{
        //    var t = Type.GetType("EngineeringUnits.Units." + item + "Unit, EngineeringUnits");
        //    FieldInfo u = t.GetFields().FirstOrDefault();

        //    alias1 = ((UnitTypebase)u.GetValue(u)).Unit;
        //    foreach (var i in list2)
        //    {
        //        var t1 = Type.GetType("EngineeringUnits.Units." + i + "Unit, EngineeringUnits");
        //        FieldInfo u1 = t1.GetFields().FirstOrDefault();

        //        alias2 = ((UnitTypebase)u1.GetValue(u1)).Unit;
        //        if (alias2 == alias1 && item != i)
        //            if (!re.Exists(e => e.EndsWith($"={i},")))

        //                re.Add($"{i}={item},");
        //    }
        //}
        //// 22 units in the output
        //foreach (var i in re)
        //{
        //    Console.WriteLine(i);

        //    var P1 = Power.FromKilowatt(10);
        //    //var L1 = Length.FromChain(2);
        //    var T1 = Temperature.FromDegreesCelsius(4);

        //    var Th = ThermalConductivity.FromBtuPerHourFootFahrenheit(10);

        //    //for (int k = 0; k < 100000000; k++)
        //    //{
        //    //    var test22 = (P1 / (L1 * T1)) + Th;

        //    //}

        //    var p1 = new Power(5, PowerUnit.SI);
        //    var p2 = new Power(10, PowerUnit.SI);
        //    var p3 = new Power(15, PowerUnit.SI);

        //    var v1 = new UVector(p1, p2);
        //    UVector v2 = v1 + v1;
        //    Power PDot = UVector.DotProduct(v1, v1);

        //    var v3 = new UVector(p1, p2, p3);
        //    var v4 = new UVector(p2, p2, p2);
        //    var PCross = UVector.CrossProduct(v3, v4);

        //    //Creating a unit that is not yet cast to a specific unit
        //    UnknownUnit unknown = Energy.FromSI(10) / Duration.FromSI(10);
        //    // {1 W}

        //    //You could cast it to BaseUnit but you lose the nice looking symbols
        //    var baseunit = (BaseUnit)unknown;
        //    // {1 kgm²/s³}

        //    //Casting it to a specifig unit. It runs the check and will throw an error if the user set it to a wrong unit
        //    Power power = unknown;
        //    //{1 W}

        //    //Trying to cast to a wrong unit
        //    //Energy energy = unknown;
        //    //WrongUnitException

        //    var Ptest = new Pressure(10m, PressureUnit.Bar);
        //    Pressure Ptest2 = Ptest.ToUnit(PressureReference.Gauge);
        //    Pressure Ptest3 = Ptest.ToUnit(PressureReference.Absolute);

        //    var teststring2 = Ptest2.ToString();
        //    var teststring4 = Ptest3.ToString();

        //    var test121 = new Acceleration(0, AccelerationUnit.SI);

        //    //foreach (var item in AngleUnit.ListOf<AngleUnit>())
        //    //{

        //    //    PrintOut += $"[{item}], ";
        //    //}

        //    //List<string> lllist = new List<string>();

        //    //List<string> assembly = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass","Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };

        //    //foreach (string assemblyName in assembly)
        //    //{
        //    //    var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");
        //    //    PrintOut += "\n"+assemblyName+":";
        //    //    foreach (var item in t.GetFields()) { 

        //    //    PrintOut+=$"[{item.GetValue(item)}], ";}
        //    //}

        //    //string PrintOut = $"Acceleration: [{AccelerationUnit.SI}]";

        //    var S1 = new SpecificEntropy(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
        //    SpecificHeatCapacity S2 = new SpecificEntropy(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
        //    // SpecificHeatCapacity S3 = new SpecificHeatCapacity(10, SpecificEntropyUnit.JoulePerKilogramKelvin);
        //    SpecificHeatCapacity S4 = S1;

        //    var ResultEvapTemperature = new Temperature(10, TemperatureUnit.DegreeCelsius);

        //    var jsonString1 = JsonConvert.SerializeObject(ResultEvapTemperature);
        //    Temperature JSON = JsonConvert.DeserializeObject<Temperature>(jsonString1);

        //    var teststring = $"{JSON}";

        //    UnknownUnit area = new Area(10, AreaUnit.SquareMeter).Sqrt();

        //    var Check = new Pressure(0, PressureUnit.Pascal);
        //    Pressure Check2 = Pressure.Zero;
        //    Pressure Check3 = 0;
        //    var Check4 = new Pressure();

        //    Debug.Print((Check == Pressure.Zero).ToString());
        //    Debug.Print((Check != Pressure.Zero).ToString());

        //    Debug.Print((Check2 == Pressure.Zero).ToString());
        //    Debug.Print((Check2 != Pressure.Zero).ToString());

        //    Debug.Print((Check3 == Pressure.Zero).ToString());
        //    Debug.Print((Check3 != Pressure.Zero).ToString());

        //    Debug.Print((Check4 == Pressure.Zero).ToString());
        //    Debug.Print((Check4 != Pressure.Zero).ToString());

        //    //Temperature T1 = new Temperature(10.572455, TemperatureUnit.DegreeCelsius);

        //    //This will as standard use 4 significant digits
        //    var Output1 = T1.ToString(); // 10.57 °C

        //    //This will as use 5 significant digits
        //    var Output2 = T1.ToString("S5"); // 10.572 °C

        //    //Same as ToString but looks better
        //    var Output3 = $"{T1:S5}"; // 10.572 °C

        //    //Same as "S4" but without the unit
        //    var Output4 = $"{T1:V4}"; // 10.57

        //    //Display the unit without value
        //    var Output5 = $"{T1:UnitOnly}"; // °C

        //    //All the normal options can still be used
        //    //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

        //    //The build-in "General"
        //    var Output6 = $"{T1:G1}"; // 1E+01 °C
        //    var Output7 = $"{T1:G4}"; // 10.57 °C

        //    var Decimals = 2;
        //    var value = -0.001111546987m;

        //    var test = value.DisplaySignificantDigits(Decimals);
        //    var test2 = value.ToString("S"+Decimals.ToString());

        //    var inputVal = 300.6544;
        //    var temperature = new Temperature(inputVal, TemperatureUnit.Kelvin);
        //    Temperature temperatureConvert = temperature.ToUnit(TemperatureUnit.DegreeCelsius);

        //    Console.WriteLine($"{inputVal} K is {temperature:##.} or {temperatureConvert:0.#####}");

        //    //double test = 10;

        //    //int test2 = (int)10.4545;

        //    Speed test3 = Length.FromMeter(10) / Duration.FromSecond(1);

        //    var list = new List<double> { 1, 1.2, 0.2, 1.8, 0.5 };
        //    Debug.Print(mylist.Min().ToString());
        //    double lenght = 50; //cm
        //    double time = 4; //seconds
        //    var speed = lenght / time; // m/s
        //    var speed2 = time / lenght; // m/s

        //    var lenght2 = Length.FromCentimeter(50);
        //    var time2 = Duration.FromSecond(4);

        //    Speed speed3 = lenght2 / time2;
        //    //Speed speed4 = time2 / lenght2;

        //    Debug.Print($"{speed3}");
        //    Debug.Print($"{speed3.As(SpeedUnit.MeterPerSecond)}");
        //    Debug.Print($"{speed3.As(SpeedUnit.MeterPerMinute)}");

        //    var watch = Stopwatch.StartNew();

        //    var SqrtTest = Area.FromSI(9);
        //    //var L2 = Length.FromSI(-2);
        //    var L5 = Length.FromFoot(5);
        //    var L6 = Length.FromFoot(-10);
        //    var L7 = Length.FromFoot(10);

        //    var listofl = new List<Length>() { L2, L5, L6, L7 };

        //    IEnumerable<UnknownUnit> test111 = listofl.Abs();

        //    foreach (UnknownUnit item in test111)
        //        Debug.Print($"{item}");

        //    //Debug.Print(L2.Unit.GetHashCode().ToString());
        //    //Debug.Print(L5.Unit.GetHashCode().ToString());
        //    //Debug.Print(L6.Unit.GetHashCode().ToString());
        //    //Debug.Print(L7.Unit.GetHashCode().ToString());

        //    Area Lmix = L2 * L5;

        //    Length SqrtTest2 = Lmix.Sqrt();

        //    //UnitSystem local = Lmix.Unit.ReduceUnits();
        //    //UnitSystem local2 = Lmix.Unit.ReduceUnitsHard();

        //    var L10 = Length.FromSI(10);

        //    //List<Length> listOfL = new List<Length>();

        //    //listOfL.Add(L2);
        //    //listOfL.Add(L5);
        //    //listOfL.Add(L10);

        //    //var local = listOfL.RoundDownToNearest(Length.FromSI(1));

        //    //var test122 = new Density(1, DensityUnit.GramPerCubicCentimeter);

        //    //Debug.Print(test122.Unit.GetHashCode().ToString());

        //    var P2 = Power.FromSI(10);
        //    //Length L2 = Length.FromSI(2);
        //    var T2 = Temperature.FromSI(4);

        //    double ThermalConductivityAsSI = 0;
        //    var PowerAsSI = P2.SI;
        //    var LengthAsSI = L2.SI;
        //    var TemperatureAsSI = T2.SI;

        //    //Solver or function where calculation speed is critical!
        //    for (var n = 0; n < 1000000000; n++)
        //        ThermalConductivityAsSI = PowerAsSI / (LengthAsSI * TemperatureAsSI);

        //    var Result = ThermalConductivity.FromSI(ThermalConductivityAsSI);

        //    //ThermalConductivity test = 0;
        //    // var watch = System.Diagnostics.Stopwatch.StartNew();

        //    //for (var j = 0; j < 10000000; j++)
        //    //    ThermalConductivity TC = P2 / (L2 * T2);

        //    watch.Stop();
        //    var elapsedMs = watch.ElapsedMilliseconds;

        //    Console.WriteLine(elapsedMs.ToString());
        //    _=Console.ReadLine();

      
    }
}
