
namespace EngineeringUnits;
public static class AbsExtensions
{
    
  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Acceleration Abs(this Acceleration a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static AreaDensity Abs(this AreaDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static AreaMomentOfInertia Abs(this AreaMomentOfInertia a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Area Abs(this Area a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static BitRate Abs(this BitRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static BrakeSpecificFuelConsumption Abs(this BrakeSpecificFuelConsumption a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Capacitance Abs(this Capacitance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static CoefficientOfThermalExpansion Abs(this CoefficientOfThermalExpansion a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Density Abs(this Density a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static DynamicViscosity Abs(this DynamicViscosity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricChargeDensity Abs(this ElectricChargeDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricCharge Abs(this ElectricCharge a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricConductivity Abs(this ElectricConductivity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricCurrentDensity Abs(this ElectricCurrentDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricCurrentGradient Abs(this ElectricCurrentGradient a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricField Abs(this ElectricField a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricInductance Abs(this ElectricInductance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricPotentialChangeRate Abs(this ElectricPotentialChangeRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricPotential Abs(this ElectricPotential a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MolarMass Abs(this MolarMass a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricResistance Abs(this ElectricResistance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricResistivity Abs(this ElectricResistivity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricSurfaceChargeDensity Abs(this ElectricSurfaceChargeDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Energy Abs(this Energy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static EnergyCost Abs(this EnergyCost a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Entropy Abs(this Entropy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ForceChangeRate Abs(this ForceChangeRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ForcePerLength Abs(this ForcePerLength a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Force Abs(this Force a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Frequency Abs(this Frequency a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static FuelEfficiency Abs(this FuelEfficiency a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static HeatFlux Abs(this HeatFlux a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static HeatTransferCoefficient Abs(this HeatTransferCoefficient a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Illuminance Abs(this Illuminance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Information Abs(this Information a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Irradiance Abs(this Irradiance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Irradiation Abs(this Irradiation a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static KinematicViscosity Abs(this KinematicViscosity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static LapseRate Abs(this LapseRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static LinearDensity Abs(this LinearDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static LinearPowerDensity Abs(this LinearPowerDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static LuminousFlux Abs(this LuminousFlux a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MagneticField Abs(this MagneticField a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MagneticFlux Abs(this MagneticFlux a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Magnetization Abs(this Magnetization a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MassFlow Abs(this MassFlow a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MassFlux Abs(this MassFlux a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MassMomentOfInertia Abs(this MassMomentOfInertia a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MolarEnergy Abs(this MolarEnergy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MolarEntropy Abs(this MolarEntropy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Molarity Abs(this Molarity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Permeability Abs(this Permeability a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Permittivity Abs(this Permittivity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static PowerDensity Abs(this PowerDensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Power Abs(this Power a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static PressureChangeRate Abs(this PressureChangeRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Ratio Abs(this Ratio a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ReactiveEnergy Abs(this ReactiveEnergy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ReactivePower Abs(this ReactivePower a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static RotationalSpeed Abs(this RotationalSpeed a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificEnergy Abs(this SpecificEnergy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificEntropy Abs(this SpecificEntropy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificWeight Abs(this SpecificWeight a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Speed Abs(this Speed a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static TemperatureChangeRate Abs(this TemperatureChangeRate a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ThermalConductivity Abs(this ThermalConductivity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ThermalResistance Abs(this ThermalResistance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static TorquePerLength Abs(this TorquePerLength a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Torque Abs(this Torque a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static VolumeFlow Abs(this VolumeFlow a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static VolumePerLength Abs(this VolumePerLength a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Volume Abs(this Volume a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static WarpingMomentOfInertia Abs(this WarpingMomentOfInertia a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificThermalResistance Abs(this SpecificThermalResistance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ApparentPower Abs(this ApparentPower a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Enthalpy Abs(this Enthalpy a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificHeatCapacity Abs(this SpecificHeatCapacity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Angle Abs(this Angle a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static MolarFlow Abs(this MolarFlow a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static SpecificVolume Abs(this SpecificVolume a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static VolumetricHeatTransferCoefficient Abs(this VolumetricHeatTransferCoefficient a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Jerk Abs(this Jerk a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static AmountOfSubstance Abs(this AmountOfSubstance a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Duration Abs(this Duration a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static ElectricCurrent Abs(this ElectricCurrent a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Length Abs(this Length a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static LuminousIntensity Abs(this LuminousIntensity a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Mass Abs(this Mass a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Cost Abs(this Cost a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Temperature Abs(this Temperature a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


  /// <summary>
  /// Returns the absolute value
  /// </summary>
  public static Pressure Abs(this Pressure a)
  {
      if (a is null)
          return null;

      if (a.GetBaseValue() > 0)
          return a;

      return -a;
  }


}
