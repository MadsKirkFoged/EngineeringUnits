using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class ElectricCurrentUnit : Enumeration
    {


        public static readonly ElectricCurrentUnit SI =          new ElectricCurrentUnit(PreFix.SI, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Ampere =      new ElectricCurrentUnit(PreFix.SI, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Centiampere = new ElectricCurrentUnit(PreFix.centi, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Kiloampere =  new ElectricCurrentUnit(PreFix.kilo, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Megaampere =  new ElectricCurrentUnit(PreFix.mega, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Microampere = new ElectricCurrentUnit(PreFix.micro, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Milliampere = new ElectricCurrentUnit(PreFix.milli, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Nanoampere =  new ElectricCurrentUnit(PreFix.nano, BaseUnits.electricCurrent);
        public static readonly ElectricCurrentUnit Picoampere =  new ElectricCurrentUnit(PreFix.pico, BaseUnits.electricCurrent);


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