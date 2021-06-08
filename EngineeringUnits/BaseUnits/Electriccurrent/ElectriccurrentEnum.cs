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


        public static ElectricCurrentUnit SI = new ElectricCurrentUnit(PreFix.SI, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Ampere = new ElectricCurrentUnit(PreFix.SI, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Centiampere = new ElectricCurrentUnit(PreFix.centi, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Kiloampere = new ElectricCurrentUnit(PreFix.kilo, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Megaampere = new ElectricCurrentUnit(PreFix.mega, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Microampere = new ElectricCurrentUnit(PreFix.micro, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Milliampere = new ElectricCurrentUnit(PreFix.milli, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Nanoampere = new ElectricCurrentUnit(PreFix.nano, BaseUnits.electricCurrent);
        public static ElectricCurrentUnit Picoampere = new ElectricCurrentUnit(PreFix.pico, BaseUnits.electricCurrent);


        public ElectricCurrentUnit() { }


        public ElectricCurrentUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();
        }


        public ElectricCurrentUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Electriccurrent = this.Copy();
            Unit.Electriccurrent.Count = 1;
            Count = 1;
            Unit.Electriccurrent.ActualC = 1;
            Unit.Electriccurrent.Name = "Electriccurrent";
            Name = "Electriccurrent";
        }


        public static IEnumerable<ElectricCurrentUnit> List()
        {
            return new[] { Ampere, Centiampere, Kiloampere, Megaampere, Microampere, Milliampere, Nanoampere, Picoampere };
        }

        public ElectricCurrentUnit Copy()
        {
            return new ElectricCurrentUnit
            {
                Name = Name,
                Symbol = Symbol,
                LocalC = LocalC,
                GlobalC = GlobalC,
                B = B,
                Count = Count,
                ActualC = ActualC,
            };
        }

    }




}