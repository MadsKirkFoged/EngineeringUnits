using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits.Units;
public partial record VolumeCostUnit : UnitTypebase
{
    public static readonly VolumeCostUnit SI = new(CostUnit.SI, VolumeUnit.SI);
    public static readonly VolumeCostUnit USDollarPerCubicMeter = new(CostUnit.USDollar, VolumeUnit.CubicMeter);
    public static readonly VolumeCostUnit EuroPerCubicMeter = new(CostUnit.Euro, VolumeUnit.CubicMeter);



    public VolumeCostUnit(CostUnit cost, VolumeUnit volume)
    {
        var localUnit = cost / volume;
        var localSymbol = $"{cost}/{volume}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }

}    
