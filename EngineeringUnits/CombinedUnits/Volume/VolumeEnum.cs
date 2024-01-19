using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record VolumeUnit : UnitTypebase
    {

        public static readonly VolumeUnit SI =                   new(LengthUnit.SI);
        public static readonly VolumeUnit CubicMeter =           new(LengthUnit.Meter);
        public static readonly VolumeUnit HectocubicMeter =      new(PreFix.hecto, CubicMeter);
        public static readonly VolumeUnit KilocubicMeter =       new(PreFix.kilo, CubicMeter);
        public static readonly VolumeUnit CubicKilometer =       new(LengthUnit.Kilometer);
        public static readonly VolumeUnit CubicMicrometer =      new(LengthUnit.Micrometer);
        public static readonly VolumeUnit CubicMile =            new(LengthUnit.Mile);
        public static readonly VolumeUnit CubicMillimeter =      new(LengthUnit.Millimeter);
        public static readonly VolumeUnit CubicYard =            new(LengthUnit.Yard);
        public static readonly VolumeUnit CubicInch =            new(LengthUnit.Inch);
        public static readonly VolumeUnit CubicHectometer =      new(LengthUnit.Hectometer);
        public static readonly VolumeUnit CubicFoot =            new(LengthUnit.Foot);
        public static readonly VolumeUnit HectocubicFoot =       new(PreFix.hecto, CubicFoot);
        public static readonly VolumeUnit KilocubicFoot =        new(PreFix.kilo, CubicFoot);
        public static readonly VolumeUnit MegacubicFoot =        new(PreFix.mega, CubicFoot);
        public static readonly VolumeUnit CubicDecimeter =       new(LengthUnit.Decimeter);
        public static readonly VolumeUnit CubicCentimeter =      new(LengthUnit.Centimeter);
        public static readonly VolumeUnit Liter =                new(LengthUnit.Decimeter, "l");
        public static readonly VolumeUnit Nanoliter =            new(PreFix.nano, Liter);
        public static readonly VolumeUnit Microliter =           new(PreFix.micro, Liter);
        public static readonly VolumeUnit Milliliter =           new(PreFix.milli, Liter);
        public static readonly VolumeUnit Deciliter =            new(PreFix.deci, Liter);
        public static readonly VolumeUnit Centiliter =           new(PreFix.centi, Liter);
        public static readonly VolumeUnit Hectoliter =           new(PreFix.hecto, Liter);
        public static readonly VolumeUnit Kiloliter =            new(PreFix.kilo, Liter);
        public static readonly VolumeUnit Megaliter =            new(PreFix.mega, Liter);
        public static readonly VolumeUnit Picoliter =            new(PreFix.pico, Liter);
        public static readonly VolumeUnit AcreFoot =             new(AreaUnit.Acre, LengthUnit.Foot);
        public static readonly VolumeUnit BoardFoot =            new(AreaUnit.SquareFoot, LengthUnit.Inch, "bf");
        public static readonly VolumeUnit AuTablespoon =         new(LengthUnit.Meter, "", 2e-5m);
        public static readonly VolumeUnit ImperialBeerBarrel =   new(LengthUnit.Meter, "bl (imp.)", 0.16365924m);
        public static readonly VolumeUnit MetricTeaspoon =       new(LengthUnit.Meter, "tsp", 0.5e-5m);
        public static readonly VolumeUnit MetricCup =            new(LengthUnit.Meter, "", 0.00025m);
        public static readonly VolumeUnit ImperialGallon =       new(LengthUnit.Meter, "gal (imp.)", 0.00454609000000181429905810072407m);
        public static readonly VolumeUnit KiloimperialGallon =   new(PreFix.kilo, ImperialGallon);
        public static readonly VolumeUnit MegaimperialGallon =   new(PreFix.mega, ImperialGallon);
        public static readonly VolumeUnit ImperialOunce =        new(LengthUnit.Meter, "oz (imp.)", 2.8413062499962901241875439064617e-5m);
        public static readonly VolumeUnit ImperialPint =         new(LengthUnit.Meter, "pt (imp.)", 5.6826125e-4m);
        public static readonly VolumeUnit UsCustomaryCup =       new(LengthUnit.Meter, "", 0.0002365882365m);
        public static readonly VolumeUnit UsBeerBarrel =         new(LengthUnit.Meter, "bl (U.S.)", 0.1173477658m);
        public static readonly VolumeUnit UkTablespoon =         new(LengthUnit.Meter, "", 1.5e-5m);
        public static readonly VolumeUnit UsOunce =              new(LengthUnit.Meter, "oz (U.S.)", 2.957352956253760505068307980135e-5m);
        public static readonly VolumeUnit UsGallon =             new(UsOunce, "gal (U.S.)", 128m);
        public static readonly VolumeUnit KilousGallon =         new(PreFix.kilo, UsGallon);
        public static readonly VolumeUnit MegausGallon =         new(PreFix.mega, UsGallon);
        public static readonly VolumeUnit DecausGallon =         new(PreFix.deka, UsGallon);
        public static readonly VolumeUnit DeciusGallon =         new(PreFix.deci, UsGallon);
        public static readonly VolumeUnit HectousGallon =        new(PreFix.hecto, UsGallon);
        public static readonly VolumeUnit OilBarrel =            new(UsGallon, "bbl", 42);
        public static readonly VolumeUnit UsLegalCup =           new(LengthUnit.Meter, "", 0.00024m);
        public static readonly VolumeUnit UsPint =               new(UsOunce, "pt (U.S.)", 16);
        public static readonly VolumeUnit UsQuart =              new(UsOunce, "qt (U.S.)", 32);
        public static readonly VolumeUnit UsTablespoon =         new(UsOunce, "", 1/2m);
        public static readonly VolumeUnit UsTeaspoon =           new(UsOunce, "", 1/6m);
        //public static VolumeUnit UsLegalCup =         new VolumeUnit(UsOunce, "", 8m);






        public VolumeUnit(LengthUnit Length, string NewSymbol = null, decimal correction = 1)
        {
            Unit = new UnitSystem(Length.Pow(3) * correction, NewSymbol);     
        }

        public VolumeUnit(AreaUnit Area, LengthUnit Length)
        {
            Unit = new UnitSystem(Area * Length, 
                               $"{Area}-{Length}");
        }

        public VolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol)
        {
            Unit = new UnitSystem(Area * Length,
                                  NewSymbol);
        }


        public VolumeUnit(PreFix SI, VolumeUnit unit) : base(SI, unit) { }

        public VolumeUnit(VolumeUnit unit, string NewSymbol = "Empty", decimal correction = 1) : base(unit, NewSymbol, correction)  {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
            {
                return $"{Unit.Symbol}";
            }


            return $"{Unit}";
        }


    }

}