using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PressureUnit : Enumeration
    {
        public static PressureUnit SI =             new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static PressureUnit Pascal =         new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static PressureUnit Micropascal =    new PressureUnit(PreFix.micro, Pascal);
        public static PressureUnit Millipascal =    new PressureUnit(PreFix.milli, Pascal);
        
        public static PressureUnit Decapascal =     new PressureUnit(PreFix.deka, Pascal);
        public static PressureUnit Hectopascal =    new PressureUnit(PreFix.hecto, Pascal);
        public static PressureUnit Kilopascal =     new PressureUnit(PreFix.kilo, Pascal);
        public static PressureUnit Megapascal =     new PressureUnit(PreFix.mega, Pascal);
        public static PressureUnit Gigapascal =     new PressureUnit(PreFix.giga, Pascal);

        public static PressureUnit Atmosphere =             new PressureUnit(Pascal, "atm", 101325m);
        public static PressureUnit FootOfHead =             new PressureUnit(Pascal, "ft of head", 2989.0669m);
        public static PressureUnit InchOfMercury =          new PressureUnit(Pascal, "inHg", 1/0.000295299830714159m);
        public static PressureUnit InchOfWaterColumn =      new PressureUnit(Pascal, "wc", 249.08890833333m);
        public static PressureUnit MeterOfHead =            new PressureUnit(Pascal, "m of head", 9804.139432m);
        public static PressureUnit MillimeterOfMercury =    new PressureUnit(Pascal, "mmHg", 1/7.50061561302643e-3m);
        public static PressureUnit TechnicalAtmosphere =    new PressureUnit(Pascal, "at", 9.80680592331m * 1e4m);
        public static PressureUnit Torr =                   new PressureUnit(Pascal, "torr", 1.3332266752m * 1e2m);

        public static PressureUnit Bar =        new PressureUnit(Pascal, "bar", 100000m);
        public static PressureUnit Microbar =   new PressureUnit(PreFix.micro, Bar);
        public static PressureUnit Millibar =   new PressureUnit(PreFix.milli, Bar);
        public static PressureUnit Centibar =   new PressureUnit(PreFix.centi, Bar);
        public static PressureUnit Decibar =    new PressureUnit(PreFix.deci, Bar);
        public static PressureUnit Kilobar =    new PressureUnit(PreFix.kilo, Bar);
        public static PressureUnit Megabar =    new PressureUnit(PreFix.mega, Bar);


        //Force
        public static PressureUnit DynePerSquareCentimeter =            new PressureUnit(ForceUnit.Dyn, AreaUnit.SquareCentimeter);
        public static PressureUnit KilogramForcePerSquareCentimeter =   new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareCentimeter);
        public static PressureUnit KilogramForcePerSquareMeter =        new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareMeter);
        public static PressureUnit KilogramForcePerSquareMillimeter =   new PressureUnit(ForceUnit.KilogramForce, AreaUnit.SquareMillimeter);
        public static PressureUnit KilonewtonPerSquareCentimeter =      new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareCentimeter);
        public static PressureUnit KilonewtonPerSquareMeter =           new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareMeter);
        public static PressureUnit KilonewtonPerSquareMillimeter =      new PressureUnit(ForceUnit.Kilonewton, AreaUnit.SquareMillimeter);
        public static PressureUnit MeganewtonPerSquareMeter =           new PressureUnit(ForceUnit.Meganewton, AreaUnit.SquareMeter);

        public static PressureUnit TonneForcePerSquareCentimeter =      new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareCentimeter);
        public static PressureUnit TonneForcePerSquareMeter =           new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareMeter);
        public static PressureUnit TonneForcePerSquareMillimeter =      new PressureUnit(ForceUnit.TonneForce, AreaUnit.SquareMillimeter);

        public static PressureUnit NewtonPerSquareMillimeter =          new PressureUnit(ForceUnit.Newton, AreaUnit.SquareMillimeter);
        public static PressureUnit NewtonPerSquareCentimeter =          new PressureUnit(ForceUnit.Newton, AreaUnit.SquareCentimeter);
        public static PressureUnit NewtonPerSquareMeter =               new PressureUnit(ForceUnit.Newton, AreaUnit.SquareMeter);

        public static PressureUnit KilopoundForcePerSquareFoot =        new PressureUnit(ForceUnit.KilopoundForce, AreaUnit.SquareFoot);
        public static PressureUnit KilopoundForcePerSquareInch =        new PressureUnit(ForceUnit.KilopoundForce, AreaUnit.SquareInch, "ksi");

        public static PressureUnit PoundForcePerSquareFoot =            new PressureUnit(ForceUnit.PoundForce, AreaUnit.SquareFoot, "lb/ft²");
        public static PressureUnit PoundForcePerSquareInch =            new PressureUnit(ForceUnit.PoundForce, AreaUnit.SquareInch, "psi");

        
        public static PressureUnit PoundPerInchSecondSquared =          new PressureUnit(Pascal, "lbm/(in·s²)", 1.785796732283465e1m);






        public PressureUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit / (length.Unit * duration.Unit * duration.Unit);
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
            Unit = force.Unit / area.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{area}");
        }

    }




}