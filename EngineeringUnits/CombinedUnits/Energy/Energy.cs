using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Energy : BaseUnit
    {

        public Energy()
        {
            Unit = EnergyUnit.SI.Unit.Copy();
        }


        public Energy(decimal value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(double value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(int value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Energy From(double value, EnergyUnit unit) => new Energy(value, unit);
        public double As(EnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Energy ToUnit(EnergyUnit selectedUnit) => new Energy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Energy Zero => new Energy(0, EnergyUnit.SI);

        public static implicit operator Energy(UnknownUnit Unit)
        {
            Energy local = new Energy(0, EnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }


        //public override string ToString()
        //{
        //    //If we know the unit
        //    if (Unit.Symbol != "")
        //        return $"{As(Unit)} {Unit}";



        //    //Check if we have the unit in the list
        //    foreach (var item in EnergyUnit.List())
        //    {
        //        if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
        //            return $"{As(Unit)} {item.Unit}";
        //    }


        //    //Return unit in SI
        //    return $"{Value} {EnergyUnit.SI}";
        //}

    }
}
