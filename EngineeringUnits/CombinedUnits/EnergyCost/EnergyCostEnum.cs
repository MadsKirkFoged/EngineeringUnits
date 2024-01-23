using EngineeringUnits.Units;
using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits.Units;
public partial record EnergyCostUnit : UnitTypebase
{

    public static readonly EnergyCostUnit SI = new(CostUnit.SI, EnergyUnit.SI);
    public static readonly EnergyCostUnit USDollarPerJoule =        new(CostUnit.USDollar, EnergyUnit.Joule);
    public static readonly EnergyCostUnit USDollarPerKilojoule =    new(CostUnit.USDollar, EnergyUnit.Kilojoule);
    public static readonly EnergyCostUnit USDollarPerMegajoule =    new(CostUnit.USDollar, EnergyUnit.Megajoule);
    public static readonly EnergyCostUnit USDollarPerGigajoule =    new(CostUnit.USDollar, EnergyUnit.Gigajoule);
    public static readonly EnergyCostUnit USDollarPerKilowattHour = new(CostUnit.USDollar, EnergyUnit.KilowattHour);
    public static readonly EnergyCostUnit USDollarPerMegawattHour = new(CostUnit.USDollar, EnergyUnit.MegawattHour);


    public EnergyCostUnit(CostUnit cost, EnergyUnit energy)
    {
        var localUnit = cost / energy;
        var localSymbol = $"{cost}/{energy}";


        Unit = new UnitSystem(localUnit, localSymbol);
    }

}    
