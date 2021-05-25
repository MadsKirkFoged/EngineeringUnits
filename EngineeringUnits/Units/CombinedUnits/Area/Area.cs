using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area()
        {
            Unit.Length.Count = 2;
            Name = "Area";
        }

        public Area(double value, LengthUnit SquaredlengthUnit) : this()
        {
            Unit.Length.SelectedUnit = SquaredlengthUnit;
            SetLocalValue((decimal)value);
        }

        public decimal As(LengthUnit SquaredlengthUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = SquaredlengthUnit;
            ReturnInThisUnitSystem.Length.Count = 2;

            return ToTheOutSide(ReturnInThisUnitSystem);
        }

        //Every units needs this
        public static implicit operator Area(UnknownUnit Unit)
        {
            Area local = new Area(0, LengthUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
