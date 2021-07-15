using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class TorquePerLengthUnit : Enumeration
    {

        public static readonly TorquePerLengthUnit SI =                                 new TorquePerLengthUnit(TorqueUnit.NewtonMeter,             LengthUnit.Meter);
        public static readonly TorquePerLengthUnit NewtonMeterPerMeter =                new TorquePerLengthUnit(TorqueUnit.NewtonMeter,             LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilogramForceCentimeterPerMeter =    new TorquePerLengthUnit(TorqueUnit.KilogramForceCentimeter, LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilogramForceMeterPerMeter =         new TorquePerLengthUnit(TorqueUnit.KilogramForceMeter,      LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilogramForceMillimeterPerMeter =    new TorquePerLengthUnit(TorqueUnit.KilogramForceMillimeter, LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilonewtonCentimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.KilonewtonCentimeter,    LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilonewtonMeterPerMeter =            new TorquePerLengthUnit(TorqueUnit.KilonewtonMeter,         LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilonewtonMillimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.KilonewtonMillimeter,    LengthUnit.Meter);
        public static readonly TorquePerLengthUnit KilopoundForceFootPerFoot =          new TorquePerLengthUnit(TorqueUnit.KilopoundForceFoot,      LengthUnit.Foot);
        public static readonly TorquePerLengthUnit KilopoundForceInchPerFoot =          new TorquePerLengthUnit(TorqueUnit.KilopoundForceInch,      LengthUnit.Foot);
        public static readonly TorquePerLengthUnit MeganewtonCentimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.MeganewtonCentimeter,    LengthUnit.Meter);
        public static readonly TorquePerLengthUnit MeganewtonMeterPerMeter =            new TorquePerLengthUnit(TorqueUnit.MeganewtonMeter,         LengthUnit.Meter);
        public static readonly TorquePerLengthUnit MeganewtonMillimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.MeganewtonMillimeter,    LengthUnit.Meter);
        public static readonly TorquePerLengthUnit MegapoundForceFootPerFoot =          new TorquePerLengthUnit(TorqueUnit.MegapoundForceFoot,      LengthUnit.Foot);
        public static readonly TorquePerLengthUnit MegapoundForceInchPerFoot =          new TorquePerLengthUnit(TorqueUnit.MegapoundForceInch,      LengthUnit.Foot);
        public static readonly TorquePerLengthUnit NewtonCentimeterPerMeter =           new TorquePerLengthUnit(TorqueUnit.NewtonCentimeter,        LengthUnit.Meter);
        public static readonly TorquePerLengthUnit NewtonMillimeterPerMeter =           new TorquePerLengthUnit(TorqueUnit.NewtonMillimeter,        LengthUnit.Meter);
        public static readonly TorquePerLengthUnit PoundForceFootPerFoot =              new TorquePerLengthUnit(TorqueUnit.PoundForceFoot,          LengthUnit.Foot);
        public static readonly TorquePerLengthUnit PoundForceInchPerFoot =              new TorquePerLengthUnit(TorqueUnit.PoundForceInch,          LengthUnit.Foot);
        public static readonly TorquePerLengthUnit TonneForceCentimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.TonneForceCentimeter,    LengthUnit.Meter);
        public static readonly TorquePerLengthUnit TonneForceMeterPerMeter =            new TorquePerLengthUnit(TorqueUnit.TonneForceMeter,         LengthUnit.Meter);
        public static readonly TorquePerLengthUnit TonneForceMillimeterPerMeter =       new TorquePerLengthUnit(TorqueUnit.TonneForceMillimeter,    LengthUnit.Meter);



        public TorquePerLengthUnit(TorqueUnit torque,LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = torque / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{torque}/{Length}");
        }

        

    }




}