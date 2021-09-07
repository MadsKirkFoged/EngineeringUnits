using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public static class UnknownUnitExtensions
    {

       public static BaseUnit IntelligentCast(this UnknownUnit toCast)
        {
            BaseUnit output = (BaseUnit) toCast;
            UnitSystem unit = output.Unit;
			if (toCast.unitsystem == AmountOfSubstanceUnit.SI.Unit)
			{
				return (AmountOfSubstance) toCast;
			}
			if (toCast.unitsystem == DurationUnit.SI.Unit)
			{
				return (Duration) toCast;
			}
			if (toCast.unitsystem == ElectricCurrentUnit.SI.Unit)
			{
				return (ElectricCurrent) toCast;
			}
			if (toCast.unitsystem == LengthUnit.SI.Unit)
			{
				return (Length) toCast;
			}
			if (toCast.unitsystem == LuminousIntensityUnit.SI.Unit)
			{
				return (LuminousIntensity) toCast;
			}
			if (toCast.unitsystem == MassUnit.SI.Unit)
			{
				return (Mass) toCast;
			}
			if (toCast.unitsystem == TemperatureDeltaUnit.SI.Unit)
			{
				return (TemperatureDelta) toCast;
			}
			if (toCast.unitsystem == TemperatureUnit.SI.Unit)
			{
				return (Temperature) toCast;
			}
			if (toCast.unitsystem == AccelerationUnit.SI.Unit)
			{
				return (Acceleration) toCast;
			}
			if (toCast.unitsystem == AreaUnit.SI.Unit)
			{
				return (Area) toCast;
			}
			if (toCast.unitsystem == DensityUnit.SI.Unit)
			{
				return (Density) toCast;
			}
			if (toCast.unitsystem == DynamicViscosityUnit.SI.Unit)
			{
				return (DynamicViscosity) toCast;
			}
			if (toCast.unitsystem == ElectricPotentialUnit.SI.Unit)
			{
				return (ElectricPotential) toCast;
			}
			if (toCast.unitsystem == MolarMassUnit.SI.Unit)
			{
				return (MolarMass) toCast;
			}
			if (toCast.unitsystem == EnergyUnit.SI.Unit)
			{
				return (Energy) toCast;
			}
			if (toCast.unitsystem == EntropyUnit.SI.Unit)
			{
				return (Entropy) toCast;
			}
			if (toCast.unitsystem == ForcePerLengthUnit.SI.Unit)
			{
				return (ForcePerLength) toCast;
			}
			if (toCast.unitsystem == ForceUnit.SI.Unit)
			{
				return (Force) toCast;
			}
			if (toCast.unitsystem == FrequencyUnit.SI.Unit)
			{
				return (Frequency) toCast;
			}
			if (toCast.unitsystem == HeatTransferCoefficientUnit.SI.Unit)
			{
				return (HeatTransferCoefficient) toCast;
			}
			if (toCast.unitsystem == KinematicViscosityUnit.SI.Unit)
			{
				return (KinematicViscosity) toCast;
			}
			if (toCast.unitsystem == MassFlowUnit.SI.Unit)
			{
				return (MassFlow) toCast;
			}
			if (toCast.unitsystem == PowerUnit.SI.Unit)
			{
				return (Power) toCast;
			}
			if (toCast.unitsystem == PressureUnit.SI.Unit)
			{
				return (Pressure) toCast;
			}
			if (toCast.unitsystem == SpecificEnergyUnit.SI.Unit)
			{
				return (SpecificEnergy) toCast;
			}
			if (toCast.unitsystem == SpecificEntropyUnit.SI.Unit)
			{
				return (SpecificEntropy) toCast;
			}
			if (toCast.unitsystem == SpeedUnit.SI.Unit)
			{
				return (Speed) toCast;
			}
			if (toCast.unitsystem == AngleUnit.SI.Unit)
			{
				return (Angle) toCast;
			}
			if (toCast.unitsystem == ApparentPowerUnit.SI.Unit)
			{
				return (ApparentPower) toCast;
			}
			if (toCast.unitsystem == AreaDensityUnit.SI.Unit)
			{
				return (AreaDensity) toCast;
			}
			if (toCast.unitsystem == AreaMomentOfInertiaUnit.SI.Unit)
			{
				return (AreaMomentOfInertia) toCast;
			}
			if (toCast.unitsystem == BitRateUnit.SI.Unit)
			{
				return (BitRate) toCast;
			}
			if (toCast.unitsystem == BrakeSpecificFuelConsumptionUnit.SI.Unit)
			{
				return (BrakeSpecificFuelConsumption) toCast;
			}
			if (toCast.unitsystem == CapacitanceUnit.SI.Unit)
			{
				return (Capacitance) toCast;
			}
			if (toCast.unitsystem == CoefficientOfThermalExpansionUnit.SI.Unit)
			{
				return (CoefficientOfThermalExpansion) toCast;
			}
			if (toCast.unitsystem == ElectricChargeUnit.SI.Unit)
			{
				return (ElectricCharge) toCast;
			}
			if (toCast.unitsystem == ElectricChargeDensityUnit.SI.Unit)
			{
				return (ElectricChargeDensity) toCast;
			}
			if (toCast.unitsystem == ElectricConductivityUnit.SI.Unit)
			{
				return (ElectricConductivity) toCast;
			}
			if (toCast.unitsystem == ElectricCurrentDensityUnit.SI.Unit)
			{
				return (ElectricCurrentDensity) toCast;
			}
			if (toCast.unitsystem == ElectricCurrentGradientUnit.SI.Unit)
			{
				return (ElectricCurrentGradient) toCast;
			}
			if (toCast.unitsystem == ElectricFieldUnit.SI.Unit)
			{
				return (ElectricField) toCast;
			}
			if (toCast.unitsystem == ElectricInductanceUnit.SI.Unit)
			{
				return (ElectricInductance) toCast;
			}
			if (toCast.unitsystem == ElectricPotentialChangeRateUnit.SI.Unit)
			{
				return (ElectricPotentialChangeRate) toCast;
			}
			if (toCast.unitsystem == ElectricResistanceUnit.SI.Unit)
			{
				return (ElectricResistance) toCast;
			}
			if (toCast.unitsystem == ElectricResistivityUnit.SI.Unit)
			{
				return (ElectricResistivity) toCast;
			}
			if (toCast.unitsystem == ElectricSurfaceChargeDensityUnit.SI.Unit)
			{
				return (ElectricSurfaceChargeDensity) toCast;
			}
			if (toCast.unitsystem == ForceChangeRateUnit.SI.Unit)
			{
				return (ForceChangeRate) toCast;
			}
			if (toCast.unitsystem == FuelEfficiencyUnit.SI.Unit)
			{
				return (FuelEfficiency) toCast;
			}
			if (toCast.unitsystem == HeatFluxUnit.SI.Unit)
			{
				return (HeatFlux) toCast;
			}
			if (toCast.unitsystem == IlluminanceUnit.SI.Unit)
			{
				return (Illuminance) toCast;
			}
			if (toCast.unitsystem == InformationUnit.SI.Unit)
			{
				return (Information) toCast;
			}
			if (toCast.unitsystem == IrradianceUnit.SI.Unit)
			{
				return (Irradiance) toCast;
			}
			if (toCast.unitsystem == IrradiationUnit.SI.Unit)
			{
				return (Irradiation) toCast;
			}
			if (toCast.unitsystem == LapseRateUnit.SI.Unit)
			{
				return (LapseRate) toCast;
			}
			if (toCast.unitsystem == LinearDensityUnit.SI.Unit)
			{
				return (LinearDensity) toCast;
			}
			if (toCast.unitsystem == LinearPowerDensityUnit.SI.Unit)
			{
				return (LinearPowerDensity) toCast;
			}
			if (toCast.unitsystem == LuminousFluxUnit.SI.Unit)
			{
				return (LuminousFlux) toCast;
			}
			if (toCast.unitsystem == MagneticFieldUnit.SI.Unit)
			{
				return (MagneticField) toCast;
			}
			if (toCast.unitsystem == MagneticFluxUnit.SI.Unit)
			{
				return (MagneticFlux) toCast;
			}
			if (toCast.unitsystem == MagnetizationUnit.SI.Unit)
			{
				return (Magnetization) toCast;
			}
			if (toCast.unitsystem == MassFluxUnit.SI.Unit)
			{
				return (MassFlux) toCast;
			}
			if (toCast.unitsystem == MassMomentOfInertiaUnit.SI.Unit)
			{
				return (MassMomentOfInertia) toCast;
			}
			if (toCast.unitsystem == MolarEnergyUnit.SI.Unit)
			{
				return (MolarEnergy) toCast;
			}
			if (toCast.unitsystem == MolarEntropyUnit.SI.Unit)
			{
				return (MolarEntropy) toCast;
			}
			if (toCast.unitsystem == MolarityUnit.SI.Unit)
			{
				return (Molarity) toCast;
			}
			if (toCast.unitsystem == PermeabilityUnit.SI.Unit)
			{
				return (Permeability) toCast;
			}
			if (toCast.unitsystem == PermittivityUnit.SI.Unit)
			{
				return (Permittivity) toCast;
			}
			if (toCast.unitsystem == PowerDensityUnit.SI.Unit)
			{
				return (PowerDensity) toCast;
			}
			if (toCast.unitsystem == PressureChangeRateUnit.SI.Unit)
			{
				return (PressureChangeRate) toCast;
			}
			if (toCast.unitsystem == RatioUnit.SI.Unit)
			{
				return (Ratio) toCast;
			}
			if (toCast.unitsystem == ReactiveEnergyUnit.SI.Unit)
			{
				return (ReactiveEnergy) toCast;
			}
			if (toCast.unitsystem == ReactivePowerUnit.SI.Unit)
			{
				return (ReactivePower) toCast;
			}
			if (toCast.unitsystem == SpecificWeightUnit.SI.Unit)
			{
				return (SpecificWeight) toCast;
			}
			if (toCast.unitsystem == TemperatureChangeRateUnit.SI.Unit)
			{
				return (TemperatureChangeRate) toCast;
			}
			if (toCast.unitsystem == WarpingMomentOfInertiaUnit.SI.Unit)
			{
				return (WarpingMomentOfInertia) toCast;
			}
			if (toCast.unitsystem == VolumePerLengthUnit.SI.Unit)
			{
				return (VolumePerLength) toCast;
			}
			if (toCast.unitsystem == TorquePerLengthUnit.SI.Unit)
			{
				return (TorquePerLength) toCast;
			}
			if (toCast.unitsystem == ThermalConductivityUnit.SI.Unit)
			{
				return (ThermalConductivity) toCast;
			}
			if (toCast.unitsystem == ThermalResistanceUnit.SI.Unit)
			{
				return (ThermalResistance) toCast;
			}
			if (toCast.unitsystem == TorqueUnit.SI.Unit)
			{
				return (Torque) toCast;
			}
			if (toCast.unitsystem == VolumeFlowUnit.SI.Unit)
			{
				return (VolumeFlow) toCast;
			}
			if (toCast.unitsystem == VolumeUnit.SI.Unit)
			{
				return (Volume) toCast;
			}

            return output;
        }
    }
}
