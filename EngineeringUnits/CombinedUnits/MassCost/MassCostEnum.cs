using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record MassCostUnit : UnitTypebase
{
    public static readonly MassCostUnit SI = new(CostUnit.SI, MassUnit.SI);

    private MassCostUnit(CostUnit cost, MassUnit mass)
    {
        var localUnit = cost / mass;
        var localSymbol = $"{cost}/{mass}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
