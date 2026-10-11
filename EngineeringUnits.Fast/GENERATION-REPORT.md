# Generation report

- Quantities: 103
- Units: 1360
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

## Currency units: the exchange rate is read at every conversion (ExchangeRates)
- AreaCost.EuroPerSquareMeter [€/m²]: the Euro rate
- Cost.Euro [€]: the Euro rate
- Cost.BritishPound [£]: the BritishPound rate
- Cost.DanishKrone [kr]: the DKK rate
- EnergyCost.DKKPerKilowattHour [kr/kWh]: the DKK rate x 1/3600000
- LengthCost.EuroPerMeter [€/m]: the Euro rate
- MassCost.EuroPerKilogram [€/kg]: the Euro rate
- VolumeCost.EuroPerCubicMeter [€/m³]: the Euro rate

## Skipped / not transferred
- Note ApparentEnergy has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [time-2,length2,mass1]
- Note Dimensionless has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [dimensionless]
- Not transferred ElectricAdmittance: a stub in EngineeringUnits (all its constructors are commented out), so nothing can be checked against it.
- Not transferred ElectricConductance: its units in EngineeringUnits are a copy of Volume (SI = m³, CubicMeter, HectocubicMeter, ...) instead of siemens - a wrong dimension would make the analyzer accept wrong code.
- Skipped quantity ElectricPotentialAc: no ElectricPotentialAcUnit type
- Skipped quantity ElectricPotentialDc: no ElectricPotentialDcUnit type
- Note Level has no [UnitDimension] in EngineeringUnits - dimension read from its SI unit: [dimensionless]
- Skipped quantity Luminosity: no LuminosityUnit type
- Skipped quantity MassConcentration: no MassConcentrationUnit type
- Skipped quantity MassFraction: marked [Obsolete]
- Skipped quantity RelativeHumidity: marked [Obsolete]
- Skipped quantity TemperatureDelta: marked [Obsolete]
- Skipped quantity VolumeConcentration: marked [Obsolete]
