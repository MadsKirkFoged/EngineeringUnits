using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class IrradiationUnit : Enumeration
    {

        public static readonly IrradiationUnit SI = new(EnergyUnit.SI, AreaUnit.SI);
        public static readonly IrradiationUnit JoulePerSquareMeter = new(EnergyUnit.Joule, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit JoulePerSquareCentimeter = new(EnergyUnit.Joule, AreaUnit.SquareCentimeter);
        public static readonly IrradiationUnit JoulePerSquareMillimeter = new(EnergyUnit.Joule, AreaUnit.SquareMillimeter);
        public static readonly IrradiationUnit KilojoulePerSquareMeter = new(EnergyUnit.Kilojoule, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit KilowattHourPerSquareMeter = new(EnergyUnit.KilowattHour, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit MillijoulePerSquareCentimeter = new(EnergyUnit.Millijoule, AreaUnit.SquareCentimeter);
        public static readonly IrradiationUnit WattHourPerSquareMeter = new(EnergyUnit.WattHour, AreaUnit.SquareMeter);




        public IrradiationUnit(EnergyUnit energy, AreaUnit area)
        {
            Unit = new UnitSystem(energy / area, 
                               $"{energy}/{area}");
        }       

    }




}