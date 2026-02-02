using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using System;
using System.Diagnostics;
using EngineeringUnits.NumberExtensions.NumberToLength;
using System.Reflection.Metadata.Ecma335;
using EngineeringUnits.NumberExtensions.NumberToSpecificEntropy;
using EngineeringUnits.NumberExtensions.NumberToMassFlow;
using EngineeringUnits.NumberExtensions.NumberToTemperature;
using static EngineeringUnits.ExchangeRates;
using EngineeringUnits.NumberExtensions.NumberToMass;
using EngineeringUnits.NumberExtensions.NumberToVolume;
using EngineeringUnits.NumberExtensions.NumberToThermalConductivity;
using EngineeringUnits.NumberExtensions.NumberToArea;
using EngineeringUnits.NumberExtensions.NumberToRatio;
using EngineeringUnits.NumberExtensions.NumberToSpeed;
using EngineeringUnits.NumberExtensions.NumberToDensity;
using EngineeringUnits.NumberExtensions.NumberToVolumeFlow;
using EngineeringUnits.NumberExtensions.NumberToDynamicViscosity;
using EngineeringUnits.NumberExtensions.NumberToTorque;
using EngineeringUnits.NumberExtensions.NumberToPressure;
using EngineeringUnits.NumberExtensions.NumberToAmountOfSubstance;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using EngineeringUnits.Parsing;

//using UnitsNet;

namespace Sandbox;

public class Program
{
    public static readonly Power P1 = Power.FromSI(10);
    public static readonly Length L1 = Length.FromSI(2);
    public static readonly Temperature T1 = Temperature.FromSI(4);

    public record mytest
    {
        public double? OilPressure { private get; init; }
        public Pressure OilPressureEntity => OilPressure.AddUnit<PressureUnit>(OilPressure_uom);
        public string? OilPressure_uom { private get; init; }

    }

    public static void Main()
    {

        



        Length a = LengthParser.Parse("12.3 m"); 
        Length b = LengthParser.Parse("1ft");
        //Length c = LengthParser.Parse("6' 2\"");
        Length d = LengthParser.Parse("1,5 m", new CultureInfo("da-DK"));
        Length e = LengthParser.Parse("2e3 mm"); // 2000 mm
        Length f = LengthParser.Parse("12.3 km");
        Length g = LengthParser.Parse("12.3 megameter");


        Console.WriteLine(a);
        Console.WriteLine(b);
        //Console.WriteLine(c.ToUnit(LengthUnit.Meter));
        Console.WriteLine(d);
        Console.WriteLine(e.ToUnit(LengthUnit.Meter));



        //Power test = Power.FromSI(10);
        //int i = 1;

        //Ratio r = Ratio.FromSI(1) / Ratio.FromSI(1);

        //var result = (test / i) / r;



        // Q = ṁ * cp * (Tout - Tin)
        //SpecificEntropy cp = 4180.JoulePerKilogramKelvin;  // water-ish
        //MassFlow mDot = 2.KilogramPerSecond;

        //Temperature Tin = 20.DegreeCelsius;
        //Temperature Tout = 60.DegreeCelsius;

        //Power Q = mDot * cp * (Tout - Tin);
        //Console.WriteLine(Q.ToUnit(PowerUnit.Kilowatt)); // e.g. "334.4 kW"


        // q = k * A * ΔT / L
        //ThermalConductivity k = 1.4.WattPerMeterKelvin;
        //Area A = 12.SquareMeter;
        //Length L = 0.24.Meter;

        //Temperature Tin = 21.DegreeCelsius;
        //Temperature Tout = -2.DegreeCelsius;

        //Power q = k * A * (Tin - Tout) / L;


        //// q = ε σ A (T1^4 - T2^4)
        //Ratio epsilon = 0.9.DecimalFraction;
        //Area A = 2.SquareMeter;

        //Temperature T1 = 500.Kelvin;
        //Temperature T2 = 300.Kelvin;

        //Power q = epsilon * Constants.StefanBoltzmannConstant * A * (T1.Pow(4) - T2.Pow(4));


        //Temperature room = 21.DegreeCelsius;

        //Temperature f = room.ToUnit(TemperatureUnit.DegreeFahrenheit);
        //Temperature back = f.ToUnit(TemperatureUnit.DegreeCelsius);

        //Console.WriteLine($"{room} -> {f} -> {back}");


        // Qv = v * A
        //Speed v = 5.MeterPerSecond;
        //Area A = 0.25.SquareMeter;

        //VolumeFlow Qv = v * A; // m³/s
        //Console.WriteLine(Qv);


        // ṁ = ρ * Qv
        //Density rho = 1.2.KilogramPerCubicMeter;  // air-ish
        //VolumeFlow Qv = 0.8.CubicMeterPerSecond;

        //MassFlow mDot = rho * Qv;


        // Δp = ρ g h
        //Density rho = 998.KilogramPerCubicMeter; // water-ish
        //Length h = 18.Meter;

        //Pressure dp = rho * Constants.StandardGravity * h; // Pa
        //Console.WriteLine(dp.ToUnit(PressureUnit.Bar));


        // Re = (ρ * v * D) / μ  -> should be dimensionless
        //Density rho = 1.2.KilogramPerCubicMeter;
        //Speed v = 8.MeterPerSecond;
        //Length D = 0.2.Meter;
        //DynamicViscosity mu = 1.8e-5.PascalSecond;

        //Ratio Re = (rho * v * D) / mu;
        //Console.WriteLine(Re);



        //VolumeFlow Qv = 0.35.CubicMeterPerSecond;

        //var cfm = Qv.ToUnit(VolumeFlowUnit.CubicFootPerMinute);
        //Console.WriteLine(cfm); // e.g. "741.6 ft³/min"



        // Ek = 0.5 * m * v²
        //Mass m = 1200.Kilogram;       // car-ish
        //Speed v = 27.MeterPerSecond;  // ~97 km/h

        //Energy Ek = 0.5m * m * v.Pow(2);


        // P = τ * ω
        //Torque tau = 250.NewtonMeter;
        //RotationalSpeed omega = RotationalSpeed.FromRadianPerSecond(3000);

        //Power P = tau * omega;
        //Console.WriteLine(P.ToUnit(PowerUnit.MechanicalHorsepower));


        //// F = p * A
        //Pressure p = 10.Bar;
        //Area A = 0.01.SquareMeter;

        //Force F = p * A;
        //Console.WriteLine(F);


        Pressure P = 101325.Pascal;
        Volume V = 1.CubicMeter;
        AmountOfSubstance n = 40.Mole;

        // T = (P * V) / (n * R)
        Temperature T = (P * V) / (n * Constants.IdealGasConstant);
        Console.WriteLine(T);




    }

    public partial record AreaCostUnit : UnitTypebase
    {

        public static readonly AreaCostUnit DollarPerSquareMillimeter = new AreaCostUnit(CostUnit.SI, AreaUnit.SquareMillimeter);

        public AreaCostUnit(CostUnit cost, AreaUnit area)
        {
            UnitSystem localUnit = cost / area;
            var localSymbol = $"{cost}/{area}";

            Unit = new UnitSystem(localUnit, localSymbol);
        }
    }
}
