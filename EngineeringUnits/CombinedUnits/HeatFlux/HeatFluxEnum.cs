using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class HeatFluxUnit : Enumeration
    {

        public static readonly HeatFluxUnit SI = new(PowerUnit.SI, AreaUnit.SI);
        public static readonly HeatFluxUnit WattPerSquareMeter = new(PowerUnit.Watt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit WattPerSquareInch = new(PowerUnit.Watt, AreaUnit.SquareInch);
        public static readonly HeatFluxUnit WattPerSquareFoot = new(PowerUnit.Watt, AreaUnit.SquareFoot);
        public static readonly HeatFluxUnit BtuPerHourSquareFoot = new(PowerUnit.BritishThermalUnitPerHour, AreaUnit.SquareFoot, "BTU/h·ft²");
        public static readonly HeatFluxUnit BtuPerMinuteSquareFoot = new(PowerUnit.BritishThermalUnitPerMinute, AreaUnit.SquareFoot, "BTU/min·ft²");
        public static readonly HeatFluxUnit BtuPerSecondSquareFoot = new(PowerUnit.BritishThermalUnitPerSecond, AreaUnit.SquareFoot, "BTU/s·ft²");
        public static readonly HeatFluxUnit BtuPerSecondSquareInch = new(PowerUnit.BritishThermalUnitPerSecond, AreaUnit.SquareInch, "BTU/s·in²");
        public static readonly HeatFluxUnit CaloriePerSecondSquareCentimeter = new(PowerUnit.CaloriePerSecond, AreaUnit.SquareCentimeter, "cal/s·cm²");

        public static readonly HeatFluxUnit KilocaloriePerHourSquareMeter = new(PowerUnit.KilocaloriePerHour, AreaUnit.SquareMeter, "kcal/h·m²");
        public static readonly HeatFluxUnit KilocaloriePerSecondSquareCentimeter = new(PowerUnit.KilocaloriePerSecond, AreaUnit.SquareCentimeter, "kcal/s·cm²");

        public static readonly HeatFluxUnit KilowattPerSquareMeter = new(PowerUnit.Kilowatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit MicrowattPerSquareMeter = new(PowerUnit.Microwatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit MilliwattPerSquareMeter = new(PowerUnit.Milliwatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit NanowattPerSquareMeter = new(PowerUnit.Nanowatt, AreaUnit.SquareMeter);


        public static readonly HeatFluxUnit CentiwattPerSquareMeter = new(PreFix.centi, WattPerSquareMeter);
        public static readonly HeatFluxUnit DeciwattPerSquareMeter = new(PreFix.deci, WattPerSquareMeter);


        public static readonly HeatFluxUnit PoundForcePerFootSecond = new(ForcePerLengthUnit.PoundForcePerFoot, DurationUnit.Second, "lbf/(ft·s)");
        public static readonly HeatFluxUnit PoundPerSecondCubed = new(MassUnit.Pound, DurationUnit.Second);



        public HeatFluxUnit(PowerUnit power, AreaUnit area, string NewSymbol = "Empty")
        {
            Unit = power / area;
            SetNewSymbol(NewSymbol, $"{power}/{area}");
        }

        public HeatFluxUnit(ForcePerLengthUnit force, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = force * duration;
            SetNewSymbol(NewSymbol, $"{force}*{duration}");
        }

        public HeatFluxUnit(MassUnit mass, DurationUnit duration, string NewSymbol = "Empty")
        {
            Unit = mass / (duration.Pow(3));
            SetNewSymbol(NewSymbol);
        }


        
        public HeatFluxUnit(PreFix SI, HeatFluxUnit unit) : base(SI, unit)
        {
        }


    }




}