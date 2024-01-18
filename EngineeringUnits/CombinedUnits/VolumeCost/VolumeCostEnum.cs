using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record VolumeCostUnit : UnitTypebase
{
    public static readonly VolumeCostUnit SI = new(CostUnit.SI, VolumeUnit.SI);

    private VolumeCostUnit(CostUnit cost, VolumeUnit volume)
    {
        var localUnit = cost / volume;
        var localSymbol = $"{cost}/{volume}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
