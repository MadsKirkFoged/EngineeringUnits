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


        public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            ValueLocalUnit = (decimal)value / (decimal)selectedUnit.Unit.GetActualC();
        }

        public double As(SpecificEnergyUnit energyUnit)
        {
            return (double)ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator SpecificEnergy(UnknownUnit Unit)
        {
            SpecificEnergy local = new SpecificEnergy(0, SpecificEnergyUnit.JoulePerKilogram);

            local.Transform(Unit);
            return local;
        }

        public override string ToString()
        {
            //If we know the unit
            if (Unit.Symbol != "")
                return $"{As(Unit)} {Unit}";



            //Check if we have the unit in the list
            foreach (var item in SpecificEnergyUnit.List())
            {
                if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
                    return $"{As(Unit)} {item.Unit}";
            }


            //Return unit in SI
            return $"{Value} {SpecificEnergyUnit.SI}";
        }

    }
}
