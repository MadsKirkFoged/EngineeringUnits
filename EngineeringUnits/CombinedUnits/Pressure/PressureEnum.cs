using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PressureUnit : Enumeration
    {
        public static readonly PressureUnit SI =             new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static readonly PressureUnit Pascal =         new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static readonly PressureUnit Micropascal =    new PressureUnit(PreFix.micro, Pascal);
        public static readonly PressureUnit Millipascal =    new PressureUnit(PreFix.milli, Pascal);        
        public static readonly PressureUnit Decapascal =     new PressureUnit(PreFix.deka, Pascal);
        public static readonly PressureUnit Hectopascal =    new PressureUnit(PreFix.hecto, Pascal);
        public static readonly PressureUnit Kilopascal =     new PressureUnit(PreFix.kilo, Pascal);
        public static readonly PressureUnit Megapascal =     new PressureUnit(PreFix.mega, Pascal);
        public static readonly PressureUnit Gigapascal =     new PressureUnit(PreFix.giga, Pascal);
        public static readonly PressureUnit Atmosphere =             new PressureUnit(Pascal, "atm", 101325m);
        public static readonly PressureUnit FootOfHead =             new PressureUnit(Pascal, "ft of head", 2989.0669m);
        public static readonly PressureUnit InchOfMercury =          new PressureUnit(Pascal, "inHg", 1/0.000295299830714159m);
        public static readonly PressureUnit InchOfWaterColumn =      new PressureUnit(Pascal, "wc", 249.08890833333m);
        public static readonly PressureUnit MeterOfHead =            new PressureUnit(Pascal, "m of head", 9804.139432m);
        public static readonly PressureUnit MillimeterOfMercury =    new PressureUnit(Pascal, "mmHg", 1/7.50061561302643e-3m);
        public static readonly PressureUnit TechnicalAtmosphere =    new PressureUnit(Pascal, "at", 9.80680592331m * 1e4m);
        public static readonly PressureUnit Torr =                   new PressureUnit(Pascal, "torr", 1.3332266752m * 1e2m);
        public static readonly PressureUnit Bar =        new PressureUnit(Pascal, "bar", 100000m);
        public static readonly PressureUnit Microbar =   new PressureUnit(PreFix.micro, Bar);
        public static readonly PressureUnit Millibar =   new PressureUnit(PreFix.milli, Bar);
        public static readonly PressureUnit Centibar =   new PressureUnit(PreFix.centi, Bar);
        public static readonly PressureUnit Decibar =    new PressureUnit(PreFix.deci, Bar);
        public static readonly PressureUnit Kilobar =    new PressureUnit(PreFix.kilo, Bar);
        public static readonly PressureUnit Megabar =    new PressureUnit(PreFix.mega, Bar);
        public static readonly PressureUnit DynePerSquareCentimeter =            new PressureUnit(ForceUnit.Dyn, AreaUnit.SquareCentimeter);
        public static readonly PressureUnit KilogramForcePerSquareCentimeter =   new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareCentimeter);
        public static readonly PressureUnit KilogramForcePerSquareMeter =        new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareMeter);
        public static readonly PressureUnit KilogramForcePerSquareMillimeter =   new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareMillimeter);
        public static readonly PressureUnit KilonewtonPerSquareCentimeter =      new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareCentimeter);
        public static readonly PressureUnit KilonewtonPerSquareMeter =           new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareMeter);
        public static readonly PressureUnit KilonewtonPerSquareMillimeter =      new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareMillimeter);
        public static readonly PressureUnit MeganewtonPerSquareMeter =           new PressureUnit(ForceUnit.Meganewton, AreaUnit.SquareMeter);
        public static readonly PressureUnit TonneForcePerSquareCentimeter =      new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareCentimeter);
        public static readonly PressureUnit TonneForcePerSquareMeter =           new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareMeter);
        public static readonly PressureUnit TonneForcePerSquareMillimeter =      new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareMillimeter);
        public static readonly PressureUnit NewtonPerSquareMillimeter =          new PressureUnit(ForceUnit.Newton, AreaUnit.SquareMillimeter);
        public static readonly PressureUnit NewtonPerSquareCentimeter =          new PressureUnit(ForceUnit.Newton, AreaUnit.SquareCentimeter);
        public static readonly PressureUnit NewtonPerSquareMeter =               new PressureUnit(ForceUnit.Newton, AreaUnit.SquareMeter);
        public static readonly PressureUnit KilopoundForcePerSquareFoot =        new PressureUnit(ForceUnit.KilopoundForce, AreaUnit.SquareFoot);
        public static readonly PressureUnit KilopoundForcePerSquareInch =        new PressureUnit(ForceUnit.KilopoundForce, AreaUnit.SquareInch, "ksi");
        public static readonly PressureUnit PoundForcePerSquareFoot =            new PressureUnit(ForceUnit.PoundForce, AreaUnit.SquareFoot, "lb/ft²");
        public static readonly PressureUnit PoundForcePerSquareInch =            new PressureUnit(ForceUnit.PoundForce, AreaUnit.SquareInch, "psi");
        public static readonly PressureUnit PoundPerInchSecondSquared =          new PressureUnit(Pascal, "lbm/(in·s²)", 1.785796732283465e1m);






        public PressureUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / (length * duration.Pow(2));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PressureUnit(PreFix SI, PressureUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PressureUnit(PressureUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);                  
        }


        public PressureUnit(ForceUnit force, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = force / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{area}");
        }

    }




}