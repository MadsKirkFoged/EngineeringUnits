using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record TorqueUnit : UnitTypebase
    {

        public static readonly TorqueUnit SI =                       new(ForceUnit.SI, LengthUnit.SI);
        public static readonly TorqueUnit NewtonMeter =              new(ForceUnit.Newton, LengthUnit.Meter);
        public static readonly TorqueUnit KilonewtonMeter =          new(PreFix.kilo, NewtonMeter);
        public static readonly TorqueUnit MeganewtonMeter =          new(PreFix.mega, NewtonMeter);
        public static readonly TorqueUnit NewtonMillimeter =         new(ForceUnit.Newton, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilonewtonMillimeter =     new(PreFix.kilo, NewtonMillimeter);
        public static readonly TorqueUnit MeganewtonMillimeter =     new(PreFix.mega, NewtonMillimeter);
        public static readonly TorqueUnit NewtonCentimeter =         new(ForceUnit.Newton, LengthUnit.Centimeter);
        public static readonly TorqueUnit MeganewtonCentimeter =     new(PreFix.mega, NewtonCentimeter);
        public static readonly TorqueUnit PoundalFoot =              new(ForceUnit.Poundal, LengthUnit.Foot);
        public static readonly TorqueUnit PoundForceFoot =           new(ForceUnit.PoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit PoundForceInch =           new(ForceUnit.PoundForce, LengthUnit.Inch);
        public static readonly TorqueUnit TonneForceCentimeter =     new(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static readonly TorqueUnit TonneForceMeter =          new(ForceUnit.TonneForce, LengthUnit.Meter);
        public static readonly TorqueUnit TonneForceMillimeter =     new(ForceUnit.TonneForce, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilonewtonCentimeter =     new(PreFix.kilo, NewtonCentimeter);
        public static readonly TorqueUnit KilogramForceCentimeter =  new(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static readonly TorqueUnit KilogramForceMeter =       new(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static readonly TorqueUnit KilogramForceMillimeter =  new(ForceUnit.KilogramForce, LengthUnit.Millimeter);
        public static readonly TorqueUnit KilopoundForceFoot =       new(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit MegapoundForceFoot =       new(ForceUnit.MegapoundForce, LengthUnit.Foot);
        public static readonly TorqueUnit KilopoundForceInch =       new(ForceUnit.KilopoundForce, LengthUnit.Inch);
        public static readonly TorqueUnit MegapoundForceInch =       new(ForceUnit.MegapoundForce, LengthUnit.Inch);



        public TorqueUnit(ForceUnit force, LengthUnit length)
        {
            Unit = new UnitSystem(force * length, 
                               $"{force}·{length}");
        }     

        public TorqueUnit(PreFix SI, TorqueUnit unit) : base(SI, unit)  { }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }
}