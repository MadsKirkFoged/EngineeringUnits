namespace EngineeringUnits
{
    public static class UnknownUnitExtensions
    {

		static UnitSystem amountofsubstance = AmountOfSubstance.FromSI(1).Unit;
		static UnitSystem duration = Duration.FromSI(1).Unit;
		static UnitSystem electriccurrent = ElectricCurrent.FromSI(1).Unit;
		static UnitSystem length = Length.FromSI(1).Unit;
		static UnitSystem luminousintensity = LuminousIntensity.FromSI(1).Unit;
		static UnitSystem mass = Mass.FromSI(1).Unit;
		static UnitSystem temperaturedelta = TemperatureDelta.FromSI(1).Unit;
		static UnitSystem temperature = Temperature.FromSI(1).Unit;
		static UnitSystem acceleration = Acceleration.FromSI(1).Unit;
		static UnitSystem area = Area.FromSI(1).Unit;
		static UnitSystem density = Density.FromSI(1).Unit;
		static UnitSystem dynamicviscosity = DynamicViscosity.FromSI(1).Unit;
		static UnitSystem electricpotential = ElectricPotential.FromSI(1).Unit;
		static UnitSystem molarmass = MolarMass.FromSI(1).Unit;
		static UnitSystem energy = Energy.FromSI(1).Unit;
		static UnitSystem entropy = Entropy.FromSI(1).Unit;
		static UnitSystem forceperlength = ForcePerLength.FromSI(1).Unit;
		static UnitSystem force = Force.FromSI(1).Unit;
		static UnitSystem frequency = Frequency.FromSI(1).Unit;
		static UnitSystem heattransfercoefficient = HeatTransferCoefficient.FromSI(1).Unit;
		static UnitSystem kinematicviscosity = KinematicViscosity.FromSI(1).Unit;
		static UnitSystem massflow = MassFlow.FromSI(1).Unit;
		static UnitSystem power = Power.FromSI(1).Unit;
		static UnitSystem pressure = Pressure.FromSI(1).Unit;
		static UnitSystem specificenergy = SpecificEnergy.FromSI(1).Unit;
		static UnitSystem specificentropy = SpecificEntropy.FromSI(1).Unit;
		static UnitSystem speed = Speed.FromSI(1).Unit;
		static UnitSystem angle = Angle.FromSI(1).Unit;
		static UnitSystem apparentpower = ApparentPower.FromSI(1).Unit;
		static UnitSystem areadensity = AreaDensity.FromSI(1).Unit;
		static UnitSystem areamomentofinertia = AreaMomentOfInertia.FromSI(1).Unit;
		static UnitSystem bitrate = BitRate.FromSI(1).Unit;
		static UnitSystem brakespecificfuelconsumption = BrakeSpecificFuelConsumption.FromSI(1).Unit;
		static UnitSystem capacitance = Capacitance.FromSI(1).Unit;
		static UnitSystem coefficientofthermalexpansion = CoefficientOfThermalExpansion.FromSI(1).Unit;
		static UnitSystem electriccharge = ElectricCharge.FromSI(1).Unit;
		static UnitSystem electricchargedensity = ElectricChargeDensity.FromSI(1).Unit;
		static UnitSystem electricconductivity = ElectricConductivity.FromSI(1).Unit;
		static UnitSystem electriccurrentdensity = ElectricCurrentDensity.FromSI(1).Unit;
		static UnitSystem electriccurrentgradient = ElectricCurrentGradient.FromSI(1).Unit;
		static UnitSystem electricfield = ElectricField.FromSI(1).Unit;
		static UnitSystem electricinductance = ElectricInductance.FromSI(1).Unit;
		static UnitSystem electricpotentialchangerate = ElectricPotentialChangeRate.FromSI(1).Unit;
		static UnitSystem electricresistance = ElectricResistance.FromSI(1).Unit;
		static UnitSystem electricresistivity = ElectricResistivity.FromSI(1).Unit;
		static UnitSystem electricsurfacechargedensity = ElectricSurfaceChargeDensity.FromSI(1).Unit;
		static UnitSystem forcechangerate = ForceChangeRate.FromSI(1).Unit;
		static UnitSystem fuelefficiency = FuelEfficiency.FromSI(1).Unit;
		static UnitSystem heatflux = HeatFlux.FromSI(1).Unit;
		static UnitSystem illuminance = Illuminance.FromSI(1).Unit;
		static UnitSystem information = Information.FromSI(1).Unit;
		static UnitSystem irradiance = Irradiance.FromSI(1).Unit;
		static UnitSystem irradiation = Irradiation.FromSI(1).Unit;
		static UnitSystem lapserate = LapseRate.FromSI(1).Unit;
		static UnitSystem lineardensity = LinearDensity.FromSI(1).Unit;
		static UnitSystem linearpowerdensity = LinearPowerDensity.FromSI(1).Unit;
		static UnitSystem luminousflux = LuminousFlux.FromSI(1).Unit;
		static UnitSystem magneticfield = MagneticField.FromSI(1).Unit;
		static UnitSystem magneticflux = MagneticFlux.FromSI(1).Unit;
		static UnitSystem magnetization = Magnetization.FromSI(1).Unit;
		static UnitSystem massflux = MassFlux.FromSI(1).Unit;
		static UnitSystem massmomentofinertia = MassMomentOfInertia.FromSI(1).Unit;
		static UnitSystem molarenergy = MolarEnergy.FromSI(1).Unit;
		static UnitSystem molarentropy = MolarEntropy.FromSI(1).Unit;
		static UnitSystem molarity = Molarity.FromSI(1).Unit;
		static UnitSystem permeability = Permeability.FromSI(1).Unit;
		static UnitSystem permittivity = Permittivity.FromSI(1).Unit;
		static UnitSystem powerdensity = PowerDensity.FromSI(1).Unit;
		static UnitSystem pressurechangerate = PressureChangeRate.FromSI(1).Unit;
		static UnitSystem ratio = Ratio.FromSI(1).Unit;
		static UnitSystem reactiveenergy = ReactiveEnergy.FromSI(1).Unit;
		static UnitSystem reactivepower = ReactivePower.FromSI(1).Unit;
		static UnitSystem specificweight = SpecificWeight.FromSI(1).Unit;
		static UnitSystem temperaturechangerate = TemperatureChangeRate.FromSI(1).Unit;
		static UnitSystem warpingmomentofinertia = WarpingMomentOfInertia.FromSI(1).Unit;
		static UnitSystem volumeperlength = VolumePerLength.FromSI(1).Unit;
		static UnitSystem torqueperlength = TorquePerLength.FromSI(1).Unit;
		static UnitSystem thermalconductivity = ThermalConductivity.FromSI(1).Unit;
		static UnitSystem thermalresistance = ThermalResistance.FromSI(1).Unit;
		static UnitSystem torque = Torque.FromSI(1).Unit;
		static UnitSystem volumeflow = VolumeFlow.FromSI(1).Unit;
		static UnitSystem volume = Volume.FromSI(1).Unit;
       public static BaseUnit IntelligentCast(this UnknownUnit toCast)
        {
            BaseUnit output = (BaseUnit) toCast;
            UnitSystem unit = output.Unit;
			if (unit == amountofsubstance)
			{
				return (AmountOfSubstance) toCast;
			}
			if (unit == duration)
			{
				return (Duration) toCast;
			}
			if (unit == electriccurrent)
			{
				return (ElectricCurrent) toCast;
			}
			if (unit == length)
			{
				return (Length) toCast;
			}
			if (unit == luminousintensity)
			{
				return (LuminousIntensity) toCast;
			}
			if (unit == mass)
			{
				return (Mass) toCast;
			}
			if (unit == temperaturedelta)
			{
				return (TemperatureDelta) toCast;
			}
			if (unit == temperature)
			{
				return (Temperature) toCast;
			}
			if (unit == acceleration)
			{
				return (Acceleration) toCast;
			}
			if (unit == area)
			{
				return (Area) toCast;
			}
			if (unit == density)
			{
				return (Density) toCast;
			}
			if (unit == dynamicviscosity)
			{
				return (DynamicViscosity) toCast;
			}
			if (unit == electricpotential)
			{
				return (ElectricPotential) toCast;
			}
			if (unit == molarmass)
			{
				return (MolarMass) toCast;
			}
			if (unit == energy)
			{
				return (Energy) toCast;
			}
			if (unit == entropy)
			{
				return (Entropy) toCast;
			}
			if (unit == forceperlength)
			{
				return (ForcePerLength) toCast;
			}
			if (unit == force)
			{
				return (Force) toCast;
			}
			if (unit == frequency)
			{
				return (Frequency) toCast;
			}
			if (unit == heattransfercoefficient)
			{
				return (HeatTransferCoefficient) toCast;
			}
			if (unit == kinematicviscosity)
			{
				return (KinematicViscosity) toCast;
			}
			if (unit == massflow)
			{
				return (MassFlow) toCast;
			}
			if (unit == power)
			{
				return (Power) toCast;
			}
			if (unit == pressure)
			{
				return (Pressure) toCast;
			}
			if (unit == specificenergy)
			{
				return (SpecificEnergy) toCast;
			}
			if (unit == specificentropy)
			{
				return (SpecificEntropy) toCast;
			}
			if (unit == speed)
			{
				return (Speed) toCast;
			}
			if (unit == angle)
			{
				return (Angle) toCast;
			}
			if (unit == apparentpower)
			{
				return (ApparentPower) toCast;
			}
			if (unit == areadensity)
			{
				return (AreaDensity) toCast;
			}
			if (unit == areamomentofinertia)
			{
				return (AreaMomentOfInertia) toCast;
			}
			if (unit == bitrate)
			{
				return (BitRate) toCast;
			}
			if (unit == brakespecificfuelconsumption)
			{
				return (BrakeSpecificFuelConsumption) toCast;
			}
			if (unit == capacitance)
			{
				return (Capacitance) toCast;
			}
			if (unit == coefficientofthermalexpansion)
			{
				return (CoefficientOfThermalExpansion) toCast;
			}
			if (unit == electriccharge)
			{
				return (ElectricCharge) toCast;
			}
			if (unit == electricchargedensity)
			{
				return (ElectricChargeDensity) toCast;
			}
			if (unit == electricconductivity)
			{
				return (ElectricConductivity) toCast;
			}
			if (unit == electriccurrentdensity)
			{
				return (ElectricCurrentDensity) toCast;
			}
			if (unit == electriccurrentgradient)
			{
				return (ElectricCurrentGradient) toCast;
			}
			if (unit == electricfield)
			{
				return (ElectricField) toCast;
			}
			if (unit == electricinductance)
			{
				return (ElectricInductance) toCast;
			}
			if (unit == electricpotentialchangerate)
			{
				return (ElectricPotentialChangeRate) toCast;
			}
			if (unit == electricresistance)
			{
				return (ElectricResistance) toCast;
			}
			if (unit == electricresistivity)
			{
				return (ElectricResistivity) toCast;
			}
			if (unit == electricsurfacechargedensity)
			{
				return (ElectricSurfaceChargeDensity) toCast;
			}
			if (unit == forcechangerate)
			{
				return (ForceChangeRate) toCast;
			}
			if (unit == fuelefficiency)
			{
				return (FuelEfficiency) toCast;
			}
			if (unit == heatflux)
			{
				return (HeatFlux) toCast;
			}
			if (unit == illuminance)
			{
				return (Illuminance) toCast;
			}
			if (unit == information)
			{
				return (Information) toCast;
			}
			if (unit == irradiance)
			{
				return (Irradiance) toCast;
			}
			if (unit == irradiation)
			{
				return (Irradiation) toCast;
			}
			if (unit == lapserate)
			{
				return (LapseRate) toCast;
			}
			if (unit == lineardensity)
			{
				return (LinearDensity) toCast;
			}
			if (unit == linearpowerdensity)
			{
				return (LinearPowerDensity) toCast;
			}
			if (unit == luminousflux)
			{
				return (LuminousFlux) toCast;
			}
			if (unit == magneticfield)
			{
				return (MagneticField) toCast;
			}
			if (unit == magneticflux)
			{
				return (MagneticFlux) toCast;
			}
			if (unit == magnetization)
			{
				return (Magnetization) toCast;
			}
			if (unit == massflux)
			{
				return (MassFlux) toCast;
			}
			if (unit == massmomentofinertia)
			{
				return (MassMomentOfInertia) toCast;
			}
			if (unit == molarenergy)
			{
				return (MolarEnergy) toCast;
			}
			if (unit == molarentropy)
			{
				return (MolarEntropy) toCast;
			}
			if (unit == molarity)
			{
				return (Molarity) toCast;
			}
			if (unit == permeability)
			{
				return (Permeability) toCast;
			}
			if (unit == permittivity)
			{
				return (Permittivity) toCast;
			}
			if (unit == powerdensity)
			{
				return (PowerDensity) toCast;
			}
			if (unit == pressurechangerate)
			{
				return (PressureChangeRate) toCast;
			}
			if (unit == ratio)
			{
				return (Ratio) toCast;
			}
			if (unit == reactiveenergy)
			{
				return (ReactiveEnergy) toCast;
			}
			if (unit == reactivepower)
			{
				return (ReactivePower) toCast;
			}
			if (unit == specificweight)
			{
				return (SpecificWeight) toCast;
			}
			if (unit == temperaturechangerate)
			{
				return (TemperatureChangeRate) toCast;
			}
			if (unit == warpingmomentofinertia)
			{
				return (WarpingMomentOfInertia) toCast;
			}
			if (unit == volumeperlength)
			{
				return (VolumePerLength) toCast;
			}
			if (unit == torqueperlength)
			{
				return (TorquePerLength) toCast;
			}
			if (unit == thermalconductivity)
			{
				return (ThermalConductivity) toCast;
			}
			if (unit == thermalresistance)
			{
				return (ThermalResistance) toCast;
			}
			if (unit == torque)
			{
				return (Torque) toCast;
			}
			if (unit == volumeflow)
			{
				return (VolumeFlow) toCast;
			}
			if (unit == volume)
			{
				return (Volume) toCast;
			}

            return output;
        }
    }
}
