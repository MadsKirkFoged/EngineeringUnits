using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MassFluxUnit : Enumeration
    {

        public static readonly MassFluxUnit SI = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareMeter);
        public static readonly MassFluxUnit KilogramPerSecondPerSquareMeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareMeter);

        public static readonly MassFluxUnit GramPerHourPerSquareCentimeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareCentimeter);
        public static readonly MassFluxUnit GramPerHourPerSquareMeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareMeter);
        public static readonly MassFluxUnit GramPerHourPerSquareMillimeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Hour, AreaUnit.SquareMillimeter);
        public static readonly MassFluxUnit GramPerSecondPerSquareCentimeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareCentimeter);
        public static readonly MassFluxUnit GramPerSecondPerSquareMeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareMeter);
        public static readonly MassFluxUnit GramPerSecondPerSquareMillimeter = new MassFluxUnit(MassUnit.Gram, DurationUnit.Second, AreaUnit.SquareMillimeter);

        public static readonly MassFluxUnit KilogramPerHourPerSquareCentimeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareCentimeter);
        public static readonly MassFluxUnit KilogramPerHourPerSquareMeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareMeter);
        public static readonly MassFluxUnit KilogramPerHourPerSquareMillimeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Hour, AreaUnit.SquareMillimeter);
        public static readonly MassFluxUnit KilogramPerSecondPerSquareCentimeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareCentimeter);
        public static readonly MassFluxUnit KilogramPerSecondPerSquareMillimeter = new MassFluxUnit(MassUnit.Kilogram, DurationUnit.Second, AreaUnit.SquareMillimeter);




        public MassFluxUnit(MassUnit mass, DurationUnit duration, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / (duration * area);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
            //SetNewSymbol(NewSymbol, $"{mass}/{duration}{area}");
        }


    }




}