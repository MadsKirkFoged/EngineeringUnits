using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Power : BaseUnit
    {

        public Power()
        {
            Name = "Power";
        }


        public Power(double value, PowerUnit energyUnit) : this()
        {

            Unit = energyUnit.Unit;
            ValueLocalUnit = (decimal)value;
        }

        public double As(PowerUnit energyUnit)
        {
            //return ToTheOutSide(energyUnit.Unit);
            return (double)ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator Power(UnknownUnit Unit)
        {
            Power local = new Power(0, PowerUnit.SI);

            local.Transform(Unit);
            return local;
        }

        public override string ToString()
        {
            //If we know the unit
            if (Unit.Symbol is object && Unit.Symbol != "")            
                return $"{As(Unit)} {Unit}";
            


            //Check if we have the unit in the list
            foreach (var item in PowerUnit.List())
            {
                Debug.Print($"{this.Unit.GetTotalFactor()} == {item.Unit.GetTotalFactor()}");

                if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
                    return $"{As(Unit)} {item.Unit}";
            }


            //Return unit in SI
            return $"{As(PowerUnit.SI)} {PowerUnit.SI.Unit}";
        }
    }
}
