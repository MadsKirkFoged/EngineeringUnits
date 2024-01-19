using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record VolumeCostUnit : UnitTypebase
{
    public static readonly VolumeCostUnit SI = new(CostUnit.SI, VolumeUnit.SI);
    public static readonly VolumeCostUnit USDollarPerCubicMeter = new(CostUnit.USDollar, VolumeUnit.CubicMeter);
    public static readonly VolumeCostUnit EuroPerCubicMeter = new(CostUnit.Euro, VolumeUnit.CubicMeter);



    private VolumeCostUnit(CostUnit cost, VolumeUnit volume)
    {
        var localUnit = cost / volume;
        var localSymbol = $"{cost}/{volume}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
