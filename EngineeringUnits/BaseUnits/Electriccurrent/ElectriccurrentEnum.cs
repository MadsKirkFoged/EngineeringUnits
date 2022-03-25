using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class ElectricCurrentUnit : UnitEnumbase
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


          public ElectricCurrentUnit(PreFix SI) : base(SI, BaseunitType.electricCurrent)
        {
            Unit = new UnitSystem(this);
        }     

       

    }




}