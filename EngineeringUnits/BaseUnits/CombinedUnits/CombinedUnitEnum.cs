using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class CombinedUnit : Enumeration
    {




        public CombinedUnit() { }


        //public CombinedUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        //{
        //    SetUnitSystem();
        //}

        public CombinedUnit(string symbol, decimal Constant) : base(symbol, Constant)
        {
            SetUnitSystem();
        }

        public CombinedUnit(string symbol, Fraction Constant) : base(symbol, Constant)
        {
            SetUnitSystem();
        }


        public CombinedUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Combined = (CombinedUnit)this.Clone();

            Unit.ListOfUnits.Add(Unit.Combined);
        }

       
       


    }



}