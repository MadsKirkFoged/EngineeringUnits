using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class SpecificEnergy : BaseUnit
    {

        public SpecificEnergy()
        {
            Name = "SpecificEnergy";
        }


        public SpecificEnergy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEnergy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static SpecificEnergy From(double value, SpecificEnergyUnit unit) => new SpecificEnergy(value, unit);
        public double As(SpecificEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificEnergy ToUnit(SpecificEnergyUnit selectedUnit) => new SpecificEnergy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificEnergy Zero => new SpecificEnergy(0, SpecificEnergyUnit.SI);

        public static implicit operator SpecificEnergy(UnknownUnit Unit)
        {
            SpecificEnergy local = new SpecificEnergy(0, SpecificEnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }


        //public override string ToString()
        //{
        //    //If we know the unit
        //    if (Unit.Symbol != "")
        //        return $"{As(Unit)} {Unit}";



        //    //Check if we have the unit in the list
        //    foreach (var item in SpecificEnergyUnit.List())
        //    {
        //        if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
        //            return $"{As(Unit)} {item.Unit}";
        //    }


        //    //Return unit in SI
        //    return $"{Value} {SpecificEnergyUnit.SI}";
        //}

    }
}
