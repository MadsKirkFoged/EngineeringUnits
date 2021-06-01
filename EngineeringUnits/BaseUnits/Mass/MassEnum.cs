using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    //public enum MassUnit
    //{










    //    [Vector("t", 1,1000)] Tonne,
    //    [Vector("gr",1, 0.06479891)] Grain,









    //}

    public class MassUnit : Enumeration
    {


        public static MassUnit SI = new MassUnit(PreFix.kilo, BaseUnits.mass);
        public static MassUnit Kilogram = new MassUnit(PreFix.kilo, BaseUnits.mass);
        public static MassUnit Centigram = new MassUnit(PreFix.centi, BaseUnits.mass);
        public static MassUnit Dekagram = new MassUnit(PreFix.deka, BaseUnits.mass);
        public static MassUnit Decigram = new MassUnit(PreFix.deci, BaseUnits.mass);
        public static MassUnit Gram = new MassUnit(PreFix.SI, BaseUnits.mass);
        public static MassUnit Hectogram = new MassUnit(PreFix.hecto, BaseUnits.mass);
        public static MassUnit Microgram = new MassUnit(PreFix.micro, BaseUnits.mass);
        public static MassUnit Milligram = new MassUnit(PreFix.milli, BaseUnits.mass);
        public static MassUnit Nanogram = new MassUnit(PreFix.nano, BaseUnits.mass);
        public static MassUnit Tonne = new MassUnit("t", 1 , 1000 * 1000);


        public static MassUnit EarthMass = new MassUnit("EarthMass", 1, 5.9722m * 10e24m);


        public static MassUnit Ounce = new MassUnit("oz", (1/16m), 453.59237m);
        public static MassUnit Pound = new MassUnit("lb", 1, 453.59237m);
        public static MassUnit Stone = new MassUnit("st", 14, 453.59237m);
        public static MassUnit ShortTon = new MassUnit("sT", 2000, 453.59237m);

        public static MassUnit Grain = new MassUnit("gr", 1, 0.06479891m);


        public MassUnit() { }


        public MassUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();
        }


        public MassUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Mass = this.Copy();
            Unit.Mass.Count = 1;
            Count = 1;
        }

        public static IEnumerable<MassUnit> List()
        {
            return new[] { SI };
        }


        public MassUnit Copy()
        {
            return new MassUnit
            {
                Name = Name,
                Symbol = Symbol,
                LocalC = LocalC,
                GlobalC = GlobalC,
                B = B,
                Count = Count
            };
        }
    }




}