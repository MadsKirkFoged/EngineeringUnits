namespace EngineeringUnits.Units;

public partial record ElectricConductivityUnit : UnitTypebase
{

    public static readonly ElectricConductivityUnit SI = new(ElectricAdmittanceUnit.SI, LengthUnit.SI);
    public static readonly ElectricConductivityUnit SiemensPerMeter = new(ElectricAdmittanceUnit.Siemens, LengthUnit.Meter);
    public static readonly ElectricConductivityUnit SiemensPerInch = new(ElectricAdmittanceUnit.Siemens, LengthUnit.Inch);
    public static readonly ElectricConductivityUnit SiemensPerFoot = new(ElectricAdmittanceUnit.Siemens, LengthUnit.Foot);

    public ElectricConductivityUnit(ElectricAdmittanceUnit electricAdmittance, LengthUnit Length)
    {
        Unit = new UnitSystem(electricAdmittance / Length,
                           $"{electricAdmittance}/{Length}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}