# Generation report

- Quantities: 103
- Units: 1352
- Extra EngineeringUnits member names forwarded (e.g. Temperature.FromKelvins): 8
- Member names left out because they are [Obsolete] in EngineeringUnits: 2038 (e.g. Acceleration.FromCentimetersPerSecondSquared, Acceleration.FromDecimetersPerSecondSquared, Acceleration.FromFeetPerSecondSquared)
- Constants: 52 (20 as dimension-tagged UnknownUnit)

## Alias groups (same dimension, different names)
- Angle, BitRate, Dimensionless, Information, Level, PipeSize, Ratio
- ApparentEnergy, Energy, ReactiveEnergy, Torque
- ApparentPower, Power, ReactivePower
- Area, VolumePerLength
- Enthalpy, SpecificEnergy
- Force, TorquePerLength
- ForceChangeRate, LinearPowerDensity
- ForcePerLength, Irradiation
- Frequency, RotationalSpeed
- HeatFlux, Irradiance
- LuminousFlux, LuminousIntensity
- PowerDensity, PressureChangeRate
- SpecificEntropy, SpecificHeatCapacity

Implicit conversions, like in EngineeringUnits: Dimensionless <-> Ratio, Enthalpy <-> SpecificEnergy, SpecificEntropy <-> SpecificHeatCapacity. All other aliases convert explicitly.

## Skipped / not transferred
- Note ApparentEnergy has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [time-2,length2,mass1]
- Not transferred AreaCost.EuroPerSquareMeter [€/m²]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Not transferred Cost.Euro [€]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Not transferred Cost.BritishPound [£]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Not transferred Cost.DanishKrone [kr]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Note Dimensionless has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [dimensionless]
- Not transferred ElectricAdmittance: a stub in EngineeringUnits (all its constructors are commented out), so nothing can be checked against it.
- Not transferred ElectricConductance: its units in EngineeringUnits are a copy of Volume (SI = m³, CubicMeter, HectocubicMeter, ...) instead of siemens - a wrong dimension would make the analyzer accept wrong code.
- Skipped quantity ElectricPotentialAc: no ElectricPotentialAcUnit type
- Skipped quantity ElectricPotentialDc: no ElectricPotentialDcUnit type
- Not transferred EnergyCost.DKKPerKilowattHour [kr/kWh]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Not transferred LengthCost.EuroPerMeter [€/m]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Note Level has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [dimensionless]
- Skipped quantity Luminosity: no LuminosityUnit type
- Skipped quantity MassConcentration: no MassConcentrationUnit type
- Not transferred MassCost.EuroPerKilogram [€/kg]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Skipped quantity MassFraction: marked [Obsolete]
- Skipped quantity RelativeHumidity: marked [Obsolete]
- Skipped quantity TemperatureDelta: marked [Obsolete]
- Skipped quantity VolumeConcentration: marked [Obsolete]
- Not transferred VolumeCost.EuroPerCubicMeter [€/m³]: its factor is an exchange rate, which EngineeringUnits reads at startup - a generated constant would silently go stale
- Not transferred AreaCost.FromEuroPerSquareMeter: doesn't match a unit by value
- Not transferred AreaCost.EuroPerSquareMeter: doesn't match a unit by value
- Not transferred Cost.FromEuro: doesn't match a unit by value
- Not transferred Cost.FromBritishPound: doesn't match a unit by value
- Not transferred Cost.FromDanishKrone: doesn't match a unit by value
- Not transferred Cost.Euro: doesn't match a unit by value
- Not transferred Cost.BritishPound: doesn't match a unit by value
- Not transferred Cost.DanishKrone: doesn't match a unit by value
- Not transferred EnergyCost.FromDKKPerKilowattHour: doesn't match a unit by value
- Not transferred EnergyCost.DKKPerKilowattHour: doesn't match a unit by value
- Not transferred LengthCost.FromEuroPerMeter: doesn't match a unit by value
- Not transferred LengthCost.EuroPerMeter: doesn't match a unit by value
- Not transferred MassCost.FromEuroPerKilogram: doesn't match a unit by value
- Not transferred MassCost.EuroPerKilogram: doesn't match a unit by value
- Not transferred VolumeCost.FromEuroPerCubicMeter: doesn't match a unit by value
- Not transferred VolumeCost.EuroPerCubicMeter: doesn't match a unit by value
