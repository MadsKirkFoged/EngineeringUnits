using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public record ElectricCurrentUnit : UnitTypebase
    {


        public static readonly ElectricCurrentUnit SI =          new(PreFix.SI);
        public static readonly ElectricCurrentUnit Ampere =      new(PreFix.SI);
        public static readonly ElectricCurrentUnit Centiampere = new(PreFix.centi);
        public static readonly ElectricCurrentUnit Kiloampere =  new(PreFix.kilo);
        public static readonly ElectricCurrentUnit Megaampere =  new(PreFix.mega);
        public static readonly ElectricCurrentUnit Microampere = new(PreFix.micro);
        public static readonly ElectricCurrentUnit Milliampere = new(PreFix.milli);
        public static readonly ElectricCurrentUnit Nanoampere =  new(PreFix.nano);
        public static readonly ElectricCurrentUnit Picoampere =  new(PreFix.pico);


        public ElectricCurrentUnit() { }


        public ElectricCurrentUnit(PreFix SI)
        {
            var unit = new RawUnit()
            {
                Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.electricCurrent),
                A = new Fraction(PrefixSISize(SI)),
                B = 0,
                Count = 1,
                UnitType = BaseunitType.electricCurrent,

            };

            Unit = new UnitSystem(unit);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)            
                return $"{Unit.Symbol}";          

            return $"{Unit}";
        }

    }




}