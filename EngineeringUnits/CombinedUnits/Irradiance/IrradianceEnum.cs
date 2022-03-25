using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class IrradianceUnit : UnitEnumbase
    {

        public static readonly IrradianceUnit SI = new(PowerUnit.SI, AreaUnit.SI);
        public static readonly IrradianceUnit WattPerSquareMeter = new(PowerUnit.Watt, AreaUnit.SquareMeter);
        public static readonly IrradianceUnit WattPerSquareCentimeter = new(PowerUnit.Watt, AreaUnit.SquareCentimeter);



        public static readonly IrradianceUnit KilowattPerSquareCentimeter = new(PreFix.kilo, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MegawattPerSquareCentimeter = new(PreFix.mega, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MicrowattPerSquareCentimeter = new(PreFix.micro, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MilliwattPerSquareCentimeter = new(PreFix.milli, WattPerSquareCentimeter);
        public static readonly IrradianceUnit NanowattPerSquareCentimeter = new(PreFix.nano, WattPerSquareCentimeter);
        public static readonly IrradianceUnit PicowattPerSquareCentimeter = new(PreFix.pico, WattPerSquareCentimeter);


        public static readonly IrradianceUnit KilowattPerSquareMeter = new(PreFix.kilo, WattPerSquareMeter);
        public static readonly IrradianceUnit MegawattPerSquareMeter = new(PreFix.mega, WattPerSquareMeter);
        public static readonly IrradianceUnit MicrowattPerSquareMeter = new(PreFix.micro, WattPerSquareMeter);
        public static readonly IrradianceUnit MilliwattPerSquareMeter = new(PreFix.milli, WattPerSquareMeter);
        public static readonly IrradianceUnit NanowattPerSquareMeter = new(PreFix.nano, WattPerSquareMeter);
        public static readonly IrradianceUnit PicowattPerSquareMeter = new(PreFix.pico, WattPerSquareMeter);



        public IrradianceUnit(PowerUnit power, AreaUnit area)
        {
            Unit = new UnitSystem(power / area, 
                               $"{power}/{area}");
        }       

        public IrradianceUnit(PreFix SI, IrradianceUnit unit) : base(SI, unit)  { }

     

    }




}