using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class TorqueUnit : Enumeration
    {

        public static readonly TorqueUnit SI =                       new TorqueUnit(ForceUnit.SI, LengthUnit.SI);
        public static readonly TorqueUnit NewtonMeter =              new TorqueUnit(ForceUnit.Newton, LengthUnit.Meter);
        public static readonly TorqueUnit KilonewtonMeter =          new TorqueUnit(PreFix.kilo, NewtonMeter);
        public static readonly TorqueUnit MeganewtonMeter =          new TorqueUnit(PreFix.mega, NewtonMeter);
        public static readonly TorqueUnit NewtonMillimeter =         new TorqueUnit(ForceUnit.Newton, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilonewtonMillimeter =     new TorqueUnit(PreFix.kilo, NewtonMillimeter);
        public static readonly TorqueUnit MeganewtonMillimeter =     new TorqueUnit(PreFix.mega, NewtonMillimeter);
        public static readonly TorqueUnit NewtonCentimeter =         new TorqueUnit(ForceUnit.Newton, LengthUnit.Centimeter);
        public static readonly TorqueUnit MeganewtonCentimeter =     new TorqueUnit(PreFix.mega, NewtonCentimeter);
        public static readonly TorqueUnit PoundalFoot =              new TorqueUnit(ForceUnit.Poundal, LengthUnit.Foot);
        public static readonly TorqueUnit PoundForceFoot =           new TorqueUnit(ForceUnit.PoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit PoundForceInch =           new TorqueUnit(ForceUnit.PoundForce, LengthUnit.Inch);
        public static readonly TorqueUnit TonneForceCentimeter =     new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static readonly TorqueUnit TonneForceMeter =          new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Meter);
        public static readonly TorqueUnit TonneForceMillimeter =     new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilonewtonCentimeter =     new TorqueUnit(PreFix.kilo, NewtonCentimeter);
        public static readonly TorqueUnit KilogramForceCentimeter =  new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static readonly TorqueUnit KilogramForceMeter =       new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static readonly TorqueUnit KilogramForceMillimeter =  new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilopoundForceFoot =       new TorqueUnit(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit MegapoundForceFoot =       new TorqueUnit(ForceUnit.MegapoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit KilopoundForceInch =       new TorqueUnit(ForceUnit.KilopoundForce, LengthUnit.Inch);
        public static readonly TorqueUnit MegapoundForceInch =       new TorqueUnit(ForceUnit.MegapoundForce, LengthUnit.Inch);







        public TorqueUnit(ForceUnit force, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = force * length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}·{length}");
        }

     

        public TorqueUnit(PreFix SI, TorqueUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }
    }
}