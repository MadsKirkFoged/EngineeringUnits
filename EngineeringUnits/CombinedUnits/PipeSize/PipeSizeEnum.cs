using Fractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EngineeringUnits.Units;
public partial record PipeSizeUnit : UnitTypebase
{

    public static readonly PipeSizeUnit SI = new("DN");
    public static readonly PipeSizeUnit DN = new("DN");

    public PipeSizeUnit(string NewSymbol)
    {
        Unit = new UnitSystem(1, NewSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }

}    
