using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record EnergyCostUnit : UnitTypebase
{

    public static readonly EnergyCostUnit SI = new(CostUnit.SI, EnergyUnit.SI);
    public static readonly EnergyCostUnit DollarPerJoule = new(CostUnit.USDollar, EnergyUnit.Joule);
    public static readonly EnergyCostUnit DollarPerKilojoule = new(CostUnit.USDollar, EnergyUnit.Kilojoule);
    public static readonly EnergyCostUnit DollarPerMegajoule = new(CostUnit.USDollar, EnergyUnit.Megajoule);
    public static readonly EnergyCostUnit DollarPerGigajoule = new(CostUnit.USDollar, EnergyUnit.Gigajoule);
    public static readonly EnergyCostUnit DollarPerKilowattHour = new(CostUnit.USDollar, EnergyUnit.KilowattHour);
    public static readonly EnergyCostUnit DollarPerMegawattHour = new(CostUnit.USDollar, EnergyUnit.MegawattHour);


    private EnergyCostUnit(CostUnit cost, EnergyUnit energy)
    {
        var localUnit = cost / energy;
        var localSymbol = $"{cost}/{energy}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
