using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using EngineeringUnits.Units;
using Fractions;
using System;

namespace EngineeringUnits
{

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
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
            //ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit.Copy();

        }

        public TemperatureDelta(double value, TemperatureUnit selectedUnit) :this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit.Copy();

        }

        public TemperatureDelta(decimal value, TemperatureUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit.Copy();
            SetValue(value);

            //Forcing all TemperatureDeltas to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit.Copy();

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
