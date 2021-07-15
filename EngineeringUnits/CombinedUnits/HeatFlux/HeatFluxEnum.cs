using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class HeatFluxUnit : Enumeration
    {

        public static readonly HeatFluxUnit SI = new HeatFluxUnit(PowerUnit.SI, AreaUnit.SI);
        public static readonly HeatFluxUnit WattPerSquareMeter = new HeatFluxUnit(PowerUnit.Watt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit WattPerSquareInch = new HeatFluxUnit(PowerUnit.Watt, AreaUnit.SquareInch);
        public static readonly HeatFluxUnit WattPerSquareFoot = new HeatFluxUnit(PowerUnit.Watt, AreaUnit.SquareFoot);
        public static readonly HeatFluxUnit BtuPerHourSquareFoot = new HeatFluxUnit(PowerUnit.BritishThermalUnitPerHour, AreaUnit.SquareFoot, "BTU/h·ft²");
        public static readonly HeatFluxUnit BtuPerMinuteSquareFoot = new HeatFluxUnit(PowerUnit.BritishThermalUnitPerMinute, AreaUnit.SquareFoot, "BTU/min·ft²");
        public static readonly HeatFluxUnit BtuPerSecondSquareFoot = new HeatFluxUnit(PowerUnit.BritishThermalUnitPerSecond, AreaUnit.SquareFoot, "BTU/s·ft²");
        public static readonly HeatFluxUnit BtuPerSecondSquareInch = new HeatFluxUnit(PowerUnit.BritishThermalUnitPerSecond, AreaUnit.SquareInch, "BTU/s·in²");
        public static readonly HeatFluxUnit CaloriePerSecondSquareCentimeter = new HeatFluxUnit(PowerUnit.CaloriePerSecond, AreaUnit.SquareCentimeter, "cal/s·cm²");

        public static readonly HeatFluxUnit KilocaloriePerHourSquareMeter = new HeatFluxUnit(PowerUnit.KilocaloriePerHour, AreaUnit.SquareMeter, "kcal/h·m²");
        public static readonly HeatFluxUnit KilocaloriePerSecondSquareCentimeter = new HeatFluxUnit(PowerUnit.KilocaloriePerSecond, AreaUnit.SquareCentimeter, "kcal/s·cm²");

        public static readonly HeatFluxUnit KilowattPerSquareMeter = new HeatFluxUnit(PowerUnit.Kilowatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit MicrowattPerSquareMeter = new HeatFluxUnit(PowerUnit.Microwatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit MilliwattPerSquareMeter = new HeatFluxUnit(PowerUnit.Milliwatt, AreaUnit.SquareMeter);
        public static readonly HeatFluxUnit NanowattPerSquareMeter = new HeatFluxUnit(PowerUnit.Nanowatt, AreaUnit.SquareMeter);


        public static readonly HeatFluxUnit CentiwattPerSquareMeter = new HeatFluxUnit(PreFix.centi, WattPerSquareMeter);
        public static readonly HeatFluxUnit DeciwattPerSquareMeter = new HeatFluxUnit(PreFix.deci, WattPerSquareMeter);


        public static readonly HeatFluxUnit PoundForcePerFootSecond = new HeatFluxUnit(ForcePerLengthUnit.PoundForcePerFoot, DurationUnit.Second, "lbf/(ft·s)");
        public static readonly HeatFluxUnit PoundPerSecondCubed = new HeatFluxUnit(MassUnit.Pound, DurationUnit.Second);



        public HeatFluxUnit(PowerUnit power, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{area}");
        }

        public HeatFluxUnit(ForcePerLengthUnit force, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = force * duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}*{duration}");
        }

        public HeatFluxUnit(MassUnit mass, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / (duration.Pow(3));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        
        public HeatFluxUnit(PreFix SI, HeatFluxUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}