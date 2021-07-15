using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricSurfaceChargeDensityUnit : Enumeration
    {

        public static readonly ElectricSurfaceChargeDensityUnit SI = new ElectricSurfaceChargeDensityUnit(ElectricChargeUnit.SI, AreaUnit.SI);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareMeter = new ElectricSurfaceChargeDensityUnit(ElectricChargeUnit.Coulomb, AreaUnit.SquareMeter);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareCentimeter = new ElectricSurfaceChargeDensityUnit(ElectricChargeUnit.Coulomb, AreaUnit.SquareCentimeter);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareInch = new ElectricSurfaceChargeDensityUnit(ElectricChargeUnit.Coulomb, AreaUnit.SquareInch);


        public ElectricSurfaceChargeDensityUnit(ElectricChargeUnit electricCharge, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCharge / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCharge}/{area}");
        }

       

    }




}