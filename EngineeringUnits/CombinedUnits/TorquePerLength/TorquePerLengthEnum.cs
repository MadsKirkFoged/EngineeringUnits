namespace EngineeringUnits.Units;

public partial record TorquePerLengthUnit : UnitTypebase
{

    public static readonly TorquePerLengthUnit SI = new(TorqueUnit.SI, LengthUnit.SI);
    public static readonly TorquePerLengthUnit NewtonMeterPerMeter = new(TorqueUnit.NewtonMeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilogramForceCentimeterPerMeter = new(TorqueUnit.KilogramForceCentimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilogramForceMeterPerMeter = new(TorqueUnit.KilogramForceMeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilogramForceMillimeterPerMeter = new(TorqueUnit.KilogramForceMillimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilonewtonCentimeterPerMeter = new(TorqueUnit.KilonewtonCentimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilonewtonMeterPerMeter = new(TorqueUnit.KilonewtonMeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilonewtonMillimeterPerMeter = new(TorqueUnit.KilonewtonMillimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit KilopoundForceFootPerFoot = new(TorqueUnit.KilopoundForceFoot, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit KilopoundForceInchPerFoot = new(TorqueUnit.KilopoundForceInch, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit MeganewtonCentimeterPerMeter = new(TorqueUnit.MeganewtonCentimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit MeganewtonMeterPerMeter = new(TorqueUnit.MeganewtonMeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit MeganewtonMillimeterPerMeter = new(TorqueUnit.MeganewtonMillimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit MegapoundForceFootPerFoot = new(TorqueUnit.MegapoundForceFoot, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit MegapoundForceInchPerFoot = new(TorqueUnit.MegapoundForceInch, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit NewtonCentimeterPerMeter = new(TorqueUnit.NewtonCentimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit NewtonMillimeterPerMeter = new(TorqueUnit.NewtonMillimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit PoundForceFootPerFoot = new(TorqueUnit.PoundForceFoot, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit PoundForceInchPerFoot = new(TorqueUnit.PoundForceInch, LengthUnit.Foot);
    public static readonly TorquePerLengthUnit TonneForceCentimeterPerMeter = new(TorqueUnit.TonneForceCentimeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit TonneForceMeterPerMeter = new(TorqueUnit.TonneForceMeter, LengthUnit.Meter);
    public static readonly TorquePerLengthUnit TonneForceMillimeterPerMeter = new(TorqueUnit.TonneForceMillimeter, LengthUnit.Meter);

    public TorquePerLengthUnit(TorqueUnit torque, LengthUnit Length)
    {
        Unit = new UnitSystem(torque / Length,
                           $"{torque}/{Length}");

    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}