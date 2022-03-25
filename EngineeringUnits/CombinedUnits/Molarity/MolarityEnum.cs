using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class MolarityUnit : UnitEnumbase
    {

        public static readonly MolarityUnit SI = new(AmountOfSubstanceUnit.SI, VolumeUnit.SI);
        public static readonly MolarityUnit MolesPerCubicMeter = new(AmountOfSubstanceUnit.Mole, VolumeUnit.CubicMeter);
        public static readonly MolarityUnit MolesPerLiter = new(AmountOfSubstanceUnit.Mole, VolumeUnit.Liter);
        public static readonly MolarityUnit NanomolesPerLiter = new(AmountOfSubstanceUnit.Nanomole, VolumeUnit.Liter);
        public static readonly MolarityUnit PicomolesPerLiter = new(AmountOfSubstanceUnit.Picomole, VolumeUnit.Liter);
        public static readonly MolarityUnit CentimolesPerLiter = new(AmountOfSubstanceUnit.Centimole, VolumeUnit.Liter);
        public static readonly MolarityUnit DecimolesPerLiter = new(AmountOfSubstanceUnit.Decimole, VolumeUnit.Liter);
        public static readonly MolarityUnit MicromolesPerLiter = new(AmountOfSubstanceUnit.Micromole, VolumeUnit.Liter);
        public static readonly MolarityUnit MillimolesPerLiter = new(AmountOfSubstanceUnit.Millimole, VolumeUnit.Liter);



        public MolarityUnit(AmountOfSubstanceUnit amountOfSubstance, VolumeUnit volume)
        {
            Unit = new UnitSystem(amountOfSubstance / volume, 
                               $"{amountOfSubstance}/{volume}");

        }       

    }




}