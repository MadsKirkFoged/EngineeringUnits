using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PressureUnit : Enumeration
    {
        public static PressureUnit SI = new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static PressureUnit Pascal = new PressureUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Pa");
        public static PressureUnit Micropascal = new PressureUnit(PreFix.micro, Pascal);
        public static PressureUnit Millipascal = new PressureUnit(PreFix.milli, Pascal);
        
        public static PressureUnit Decapascal = new PressureUnit(PreFix.deka, Pascal);
        public static PressureUnit Hectopascal = new PressureUnit(PreFix.hecto, Pascal);
        public static PressureUnit Kilopascal = new PressureUnit(PreFix.kilo, Pascal);
        public static PressureUnit Megapascal = new PressureUnit(PreFix.mega, Pascal);
        public static PressureUnit Gigapascal = new PressureUnit(PreFix.giga, Pascal);

        public static PressureUnit Atmosphere = new PressureUnit(Pascal, "atm", 101325m);
        public static PressureUnit FootOfHead = new PressureUnit(Pascal, "pa", 2989.0669m);
        public static PressureUnit InchOfMercury = new PressureUnit(Pascal, "pa", 1/0.000295299830714159m);
        public static PressureUnit InchOfWaterColumn = new PressureUnit(Pascal, "pa", 249.08890833333m);
        public static PressureUnit MeterOfHead = new PressureUnit(Pascal, "pa", 9804.139432m);
        public static PressureUnit MillimeterOfMercury = new PressureUnit(Pascal, "pa", 1/7.50061561302643e-3m);
        public static PressureUnit TechnicalAtmosphere = new PressureUnit(Pascal, "pa", 9.80680592331m * 1e4m);
        public static PressureUnit Torr = new PressureUnit(Pascal, "pa", 1.3332266752m * 1e2m);

        public static PressureUnit Bar = new PressureUnit(Pascal, "bar", 100000m);
        public static PressureUnit Microbar = new PressureUnit(PreFix.micro, Bar);
        public static PressureUnit Millibar = new PressureUnit(PreFix.milli, Bar);
        public static PressureUnit Centibar = new PressureUnit(PreFix.centi, Bar);
        public static PressureUnit Decibar = new PressureUnit(PreFix.deci, Bar);
        public static PressureUnit Kilobar = new PressureUnit(PreFix.kilo, Bar);
        public static PressureUnit Megabar = new PressureUnit(PreFix.mega, Bar);


        //Force
        public static PressureUnit KilogramForcePerSquareCentimeter = new PressureUnit(Pascal, "pa", 9.80665e4m);
        public static PressureUnit KilogramForcePerSquareMeter = new PressureUnit(Pascal, "pa", 9.80665019960652m);
        public static PressureUnit KilogramForcePerSquareMillimeter = new PressureUnit(Pascal, "pa", 9.80665e6m);
        public static PressureUnit KilonewtonPerSquareCentimeter = new PressureUnit(Pascal, "pa", 1e4m * 1e3m);
        public static PressureUnit KilonewtonPerSquareMeter = new PressureUnit(Pascal, "pa", 1e3m);
        public static PressureUnit KilonewtonPerSquareMillimeter = new PressureUnit(Pascal, "pa", 1e6m * 1e3m);
        public static PressureUnit MeganewtonPerSquareMeter = new PressureUnit(Pascal, "pa", 1e6m);

        public static PressureUnit TonneForcePerSquareCentimeter = new PressureUnit(Pascal, "pa", 9.80665e7m);
        public static PressureUnit TonneForcePerSquareMeter = new PressureUnit(Pascal, "pa", 9.80665e3m);
        public static PressureUnit TonneForcePerSquareMillimeter = new PressureUnit(Pascal, "pa", 9.80665e9m);
        

        public static PressureUnit NewtonPerSquareMillimeter = new PressureUnit(Pascal, "pa", 1e6m);
        public static PressureUnit NewtonPerSquareCentimeter = new PressureUnit(Pascal, "pa", 1e4m);
        public static PressureUnit NewtonPerSquareMeter = new PressureUnit(Pascal, "pa", 1m);

        public static PressureUnit KilopoundForcePerSquareFoot = new PressureUnit(Pascal, "pa", 4.788025898033584e1m * 1e3m);
        public static PressureUnit KilopoundForcePerSquareInch = new PressureUnit(Pascal, "pa", 6.894757293168361e3m * 1e3m);

        public static PressureUnit PoundForcePerSquareFoot = new PressureUnit(Pascal, "pa", 4.788025898033584e1m);
        public static PressureUnit PoundForcePerSquareInch = new PressureUnit(Pascal, "pa", 6.894757293168361e3m);
        public static PressureUnit PoundPerInchSecondSquared = new PressureUnit(Pascal, "pa", 1.785796732283465e1m);

        public static PressureUnit DynePerSquareCentimeter = new PressureUnit(Pascal, "pa", 1.0e-1m);




        public PressureUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Pressure";
            Unit = mass.Unit / (length.Unit * duration.Unit * duration.Unit);


            if (NewSymbol != "")
                Unit.Symbol = NewSymbol;


            if (correction != 1)
                Unit.Combined = new CombinedUnit("", 1, correction);


        }

        public PressureUnit(PreFix SI, PressureUnit unit)
        {
            Unit = unit.Unit.Copy();


            if (Unit.Combined is null)
                Unit.Combined = new CombinedUnit("", 1, PrefixSISize(SI));
            else
                Unit.Combined.GlobalC *= PrefixSISize(SI);




            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
        }

        public PressureUnit(PressureUnit unit, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            Unit = unit.Unit.Copy();
            //Unit.Duration.ActualC = (Fraction)(1/3600m);

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }
            else
            {
                Unit.Symbol = $"{unit}";
            }



            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", 1, correction);
            }


        }


        public static IEnumerable<PressureUnit> List()
        {
            return new[] { Atmosphere, Bar, Centibar, Decapascal, Decibar, DynePerSquareCentimeter, FootOfHead, Gigapascal, Hectopascal, InchOfMercury, InchOfWaterColumn, Kilobar, KilogramForcePerSquareCentimeter, KilogramForcePerSquareMeter, KilogramForcePerSquareMillimeter, KilonewtonPerSquareCentimeter, KilonewtonPerSquareMeter, KilonewtonPerSquareMillimeter, Kilopascal, KilopoundForcePerSquareFoot, KilopoundForcePerSquareInch, Megabar, MeganewtonPerSquareMeter, Megapascal, MeterOfHead, Microbar, Micropascal, Millibar, MillimeterOfMercury, Millipascal, NewtonPerSquareCentimeter, NewtonPerSquareMeter, NewtonPerSquareMillimeter, Pascal, PoundForcePerSquareFoot, PoundForcePerSquareInch, PoundPerInchSecondSquared, TechnicalAtmosphere, TonneForcePerSquareCentimeter, TonneForcePerSquareMeter, TonneForcePerSquareMillimeter, Torr, };
        }





    }




}