using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ElectricSurfaceChargeDensityUnit : UnitTypebase
    {

        public static readonly ElectricSurfaceChargeDensityUnit SI = new(ElectricChargeUnit.SI, AreaUnit.SI);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareMeter = new(ElectricChargeUnit.Coulomb, AreaUnit.SquareMeter);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareCentimeter = new(ElectricChargeUnit.Coulomb, AreaUnit.SquareCentimeter);
        public static readonly ElectricSurfaceChargeDensityUnit CoulombPerSquareInch = new(ElectricChargeUnit.Coulomb, AreaUnit.SquareInch);


        public ElectricSurfaceChargeDensityUnit(ElectricChargeUnit electricCharge, AreaUnit area)
        {
            Unit = new UnitSystem(electricCharge / area, 
                               $"{electricCharge}/{area}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}