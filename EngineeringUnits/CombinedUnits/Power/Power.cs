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


        public Power(decimal value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(double value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(int value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Power From(double value, PowerUnit unit) => new Power(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Power ToUnit(PowerUnit selectedUnit) => new Power(ToTheOutSide(selectedUnit.Unit), selectedUnit);


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
                return $"{ValueLocalUnit} {Unit}";
            


            //Check if we have the unit in the list
            foreach (var item in PowerUnit.List())
            {
                //Debug.Print($"{this.Unit.GetTotalFactor()} == {item.Unit.GetTotalFactor()}");

                if (this.Unit.GetTotalFactor() == item.Unit.GetTotalFactor())
                    return $"{As(Unit)} {item.Unit}";
            }


            //Return unit in SI
            return $"{As(PowerUnit.SI)} {PowerUnit.SI.Unit}";
        }
    }
}
