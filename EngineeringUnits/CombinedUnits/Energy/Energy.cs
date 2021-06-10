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
            Name = "Energy";
        }


        public Energy(double value, EnergyUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public double As(EnergyUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        //Every units needs this
        public static implicit operator Energy(UnknownUnit Unit)
        {
            Energy local = new Energy(0, EnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }

        public override string ToString()
        {
            //If we know the unit
            if (Unit.Symbol != "")
                return $"{As(Unit)} {Unit}";



            //Check if we have the unit in the list
            foreach (var item in EnergyUnit.List())
            {
                if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
                    return $"{As(Unit)} {item.Unit}";
            }


            //Return unit in SI
            return $"{Value} {EnergyUnit.SI}";
        }

    }
}
