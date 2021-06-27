using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class TorqueUnit : Enumeration
    {

        public static TorqueUnit SI = new TorqueUnit(ForceUnit.Newton, LengthUnit.Meter);
        public static TorqueUnit NewtonMeter = new TorqueUnit(ForceUnit.Newton, LengthUnit.Meter);
        public static TorqueUnit KilonewtonMeter = new TorqueUnit(PreFix.kilo, NewtonMeter);
        public static TorqueUnit MeganewtonMeter = new TorqueUnit(PreFix.mega, NewtonMeter);

        public static TorqueUnit NewtonMillimeter = new TorqueUnit(ForceUnit.Newton, LengthUnit.Millimeter);
        public static TorqueUnit KilonewtonMillimeter = new TorqueUnit(PreFix.kilo, NewtonMillimeter);
        public static TorqueUnit MeganewtonMillimeter = new TorqueUnit(PreFix.mega, NewtonMillimeter);

        public static TorqueUnit NewtonCentimeter = new TorqueUnit(ForceUnit.Newton, LengthUnit.Centimeter);
        public static TorqueUnit MeganewtonCentimeter = new TorqueUnit(PreFix.mega, NewtonCentimeter);

        public static TorqueUnit PoundalFoot = new TorqueUnit(ForceUnit.Poundal, LengthUnit.Foot);
        public static TorqueUnit PoundForceFoot = new TorqueUnit(ForceUnit.PoundForce, LengthUnit.Foot);
        public static TorqueUnit PoundForceInch = new TorqueUnit(ForceUnit.PoundForce, LengthUnit.Inch);
        public static TorqueUnit TonneForceCentimeter = new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static TorqueUnit TonneForceMeter = new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Meter);
        public static TorqueUnit TonneForceMillimeter = new TorqueUnit(ForceUnit.TonneForce, LengthUnit.Millimeter);
        public static TorqueUnit KilonewtonCentimeter = new TorqueUnit(PreFix.kilo, NewtonCentimeter);


        public static TorqueUnit KilogramForceCentimeter = new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static TorqueUnit KilogramForceMeter = new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static TorqueUnit KilogramForceMillimeter = new TorqueUnit(ForceUnit.KilogramForce, LengthUnit.Millimeter);
        public static TorqueUnit KilopoundForceFoot = new TorqueUnit(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static TorqueUnit MegapoundForceFoot = new TorqueUnit(ForceUnit.MegapoundForce, LengthUnit.Foot);
        public static TorqueUnit KilopoundForceInch = new TorqueUnit(ForceUnit.KilopoundForce, LengthUnit.Inch);
        public static TorqueUnit MegapoundForceInch = new TorqueUnit(ForceUnit.MegapoundForce, LengthUnit.Inch);







        public TorqueUnit(ForceUnit force, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "Torque";
            Unit = force.Unit * length.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}·{length}");

        }

     

        public TorqueUnit(PreFix SI, TorqueUnit unit)
        {
            //Name = "Torque";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }



        public static IEnumerable<TorqueUnit> List()
        {
            return new[] { KilogramForceCentimeter, KilogramForceMeter, KilogramForceMillimeter, KilonewtonCentimeter, KilonewtonMeter, KilonewtonMillimeter, KilopoundForceFoot, KilopoundForceInch, MeganewtonCentimeter, MeganewtonMeter, MeganewtonMillimeter, MegapoundForceFoot, MegapoundForceInch, NewtonCentimeter, NewtonMeter, NewtonMillimeter, PoundalFoot, PoundForceFoot, PoundForceInch, TonneForceCentimeter, TonneForceMeter, TonneForceMillimeter, };
        }





    }




}