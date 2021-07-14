using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IrradiationUnit : Enumeration
    {

        public static readonly IrradiationUnit SI = new IrradiationUnit(EnergyUnit.Joule, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit JoulePerSquareMeter = new IrradiationUnit(EnergyUnit.Joule, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit JoulePerSquareCentimeter = new IrradiationUnit(EnergyUnit.Joule, AreaUnit.SquareCentimeter);
        public static readonly IrradiationUnit JoulePerSquareMillimeter = new IrradiationUnit(EnergyUnit.Joule, AreaUnit.SquareMillimeter);
        public static readonly IrradiationUnit KilojoulePerSquareMeter = new IrradiationUnit(EnergyUnit.Kilojoule, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit KilowattHourPerSquareMeter = new IrradiationUnit(EnergyUnit.KilowattHour, AreaUnit.SquareMeter);
        public static readonly IrradiationUnit MillijoulePerSquareCentimeter = new IrradiationUnit(EnergyUnit.Millijoule, AreaUnit.SquareCentimeter);
        public static readonly IrradiationUnit WattHourPerSquareMeter = new IrradiationUnit(EnergyUnit.WattHour, AreaUnit.SquareMeter);




        public IrradiationUnit(EnergyUnit energy, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{area}");
        }       

    }




}