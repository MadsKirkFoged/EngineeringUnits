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
            Unit = TemperatureUnit.SI.Unit.Copy();
        }

        public TemperatureDelta(int value, TemperatureUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public TemperatureDelta(double value, TemperatureUnit selectedUnit) :this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public TemperatureDelta(decimal value, TemperatureUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public static TemperatureDelta From(double value, TemperatureUnit unit) => new TemperatureDelta(value, unit);

        public double As(TemperatureUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);

        public TemperatureDelta ToUnit(TemperatureUnit selectedUnit)
        {
            return new TemperatureDelta(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }
        public static TemperatureDelta Zero => new TemperatureDelta(0, TemperatureUnit.SI);

        public static implicit operator TemperatureDelta(UnknownUnit Unit)
        {
            TemperatureDelta local = new TemperatureDelta(0, TemperatureUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
