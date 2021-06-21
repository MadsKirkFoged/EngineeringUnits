using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class TemperatureDelta : BaseUnit
    {

        public TemperatureDelta()
        {
            Name = "TemperatureDelta";
        }

        public TemperatureDelta(int value, TemperatureDeltaUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            Unit = TemperatureDeltaUnit.Kelvin.Unit;

        }

        public TemperatureDelta(double value, TemperatureDeltaUnit selectedUnit) :this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            Unit = TemperatureDeltaUnit.Kelvin.Unit;

        }

        public TemperatureDelta(decimal value, TemperatureDeltaUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            Unit = TemperatureDeltaUnit.Kelvin.Unit;

        }

        public static TemperatureDelta From(double value, TemperatureDeltaUnit unit) => new TemperatureDelta(value, unit);

        public double As(TemperatureDeltaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);

        public TemperatureDelta ToUnit(TemperatureDeltaUnit selectedUnit)
        {
            return new TemperatureDelta(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }
        public static TemperatureDelta Zero => new TemperatureDelta(0, TemperatureDeltaUnit.SI);

        public static implicit operator TemperatureDelta(UnknownUnit Unit)
        {
            TemperatureDelta local = new TemperatureDelta(0, TemperatureDeltaUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
