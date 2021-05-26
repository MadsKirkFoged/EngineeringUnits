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

    //    [Vector(PreFix.centi,   BaseUnits.mass)] Centigram,
    //    [Vector(PreFix.deka,    BaseUnits.mass)] Dekagram,
    //    [Vector(PreFix.deci,    BaseUnits.mass)] Decigram,
    //    [Vector(PreFix.SI,      BaseUnits.mass)] Gram,
    //    [Vector(PreFix.hecto,   BaseUnits.mass)] Hectogram,
    //    [Vector(PreFix.kilo,    BaseUnits.mass)] Kilogram,
    //    [Vector(PreFix.micro,   BaseUnits.mass)] Microgram,
    //    [Vector(PreFix.milli,   BaseUnits.mass)] Milligram,
    //    [Vector(PreFix.nano,    BaseUnits.mass)] Nanogram,

    //    [Vector("t", 1,1000)] Tonne,
    //    [Vector("gr",1, 0.06479891)] Grain,


    //    [Vector("oz",1, (1/16d) * 453.59237)] Ounce,
    //    [Vector("lb",1, 1 *       453.59237)] Pound,
    //    [Vector("st",1, 14 *      453.59237)] Stone,
    //    [Vector("lb",1, 2000 *    453.59237)] ShortTon,

    //    //[Vector(1, "EarthMass", 5.9722*10e24)] EarthMass,


    //}

    public class MassUnit : Enumeration
    {


        public static MassUnit SI = new MassUnit(PreFix.kilo, BaseUnits.mass);




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
                A1 = A1,
                A2 = A2,
                B = B,
                Count = Count
            };
        }
    }




}