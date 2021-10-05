using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class ElectricCurrentUnit : Enumeration
    {


        public static readonly ElectricCurrentUnit SI =          new(PreFix.SI, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Ampere =      new(PreFix.SI, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Centiampere = new(PreFix.centi, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Kiloampere =  new(PreFix.kilo, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Megaampere =  new(PreFix.mega, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Microampere = new(PreFix.micro, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Milliampere = new(PreFix.milli, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Nanoampere =  new(PreFix.nano, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Picoampere =  new(PreFix.pico, BaseUnits.electricCurrent);


        public ElectricCurrentUnit() { }


        public ElectricCurrentUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Electriccurrent = (ElectricCurrentUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public ElectricCurrentUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Electriccurrent = (ElectricCurrentUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }     

       

    }




}