﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

[Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
public partial class TemperatureDelta : BaseUnit
{

    public TemperatureDelta()
    {
        //Unit = TemperatureUnit.SI.Unit.Copy();
    }

    public TemperatureDelta(int value, TemperatureUnit selectedUnit) : this()
    {

        //Unit = selectedUnit.Unit;
        //SetValue(value);

        ////Forcing all TemperatureDeltas to stay in kelvin
        ////ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
        //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
        //Unit = TemperatureUnit.Kelvin.Unit.Copy();

    }

    public TemperatureDelta(double value, TemperatureUnit selectedUnit) : this()
    {

        //Unit = selectedUnit.Unit;
        //SetValue(value);

        ////Forcing all TemperatureDeltas to stay in kelvin
        ////ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
        //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
        //Unit = TemperatureUnit.Kelvin.Unit.Copy();

    }

    public TemperatureDelta(decimal value, TemperatureUnit selectedUnit) : this()
    {

        //Unit = selectedUnit.Unit.Copy();
        //SetValue(value);

        ////Forcing all TemperatureDeltas to stay in kelvin
        ////ValueLocalUnit = ToTheOutSide(TemperatureDeltaUnit.Kelvin.Unit);
        //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
        //Unit = TemperatureUnit.Kelvin.Unit.Copy();

    }

    public static TemperatureDelta From(double value, TemperatureUnit unit) => new(value, unit);

    public double As(TemperatureUnit ReturnInThisUnit) => (double)this.GetValueAs(ReturnInThisUnit.Unit);

    public TemperatureDelta ToUnit(TemperatureUnit selectedUnit) => new TemperatureDelta(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static TemperatureDelta Zero => new(0, TemperatureUnit.SI);

    public static implicit operator TemperatureDelta(UnknownUnit Unit)
    {
        TemperatureDelta local = new(0, TemperatureUnit.SI);

        //local.Transform(Unit);
        return local;
    }
}
