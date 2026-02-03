using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits;
using System;

namespace UnitTests.Parsing
{
    [TestClass]
    public class QuantityParse_StupidRegressionTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // -------------------- ENERGY (and aliases) --------------------
        [TestMethod]
        public void Energy_Torque_ReactiveEnergy_Stupid()
        {
            // Energy
            Assert.AreEqual(1m, Energy.Parse("1 J", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Energy.Parse("1 (N*m)", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Energy.Parse("1 kg*m^2/s^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Energy.Parse("1 kg m^2 / s^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Energy.Parse("1 Pa*m^3", Inv).AsSI, 1e-9m);
            Assert.AreEqual(3600m, Energy.Parse("1 W*h", Inv).AsSI, 1e-6m);
            Assert.AreEqual(3600m, Energy.Parse("1 W h", Inv).AsSI, 1e-6m);
            Assert.AreEqual(7200m, Energy.Parse("2 W*h", Inv).AsSI, 1e-6m);

            Assert.AreEqual(1e-9m, Energy.Parse("0.000000001 J", Inv).AsSI, 1e-18m);
            Assert.AreEqual(1_000_000_000m, Energy.Parse("1000000000 J", Inv).AsSI, 1e-3m);

            // Torque (same dimensions as Energy in your model; you said this is OK)
            Assert.AreEqual(1m, Torque.Parse("1 N*m", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Torque.Parse("1 kg*m^2/s^2", Inv).AsSI, 1e-9m);

            // ReactiveEnergy (same dimension group as Energy)
            Assert.AreEqual(1m, ReactiveEnergy.Parse("1 J", Inv).AsSI, 1e-9m);
            Assert.AreEqual(3600m, ReactiveEnergy.Parse("1 W*h", Inv).AsSI, 1e-6m);
        }

        // -------------------- POWER (+ aliases) --------------------
        [TestMethod]
        public void Power_ApparentPower_ReactivePower_Stupid()
        {
            Assert.AreEqual(1m, Power.Parse("1 W", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Power.Parse("1 J/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Power.Parse("1 (N*m)/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Power.Parse("1 Pa*m^3/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Power.Parse("1 V*A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Power.Parse("2 V*A", Inv).AsSI, 1e-9m);

            Assert.AreEqual(0.001m, Power.Parse("0.001 W", Inv).AsSI, 1e-12m);
            Assert.AreEqual(1_000_000m, Power.Parse("1000000 W", Inv).AsSI, 1e-6m);

            // Same-dimension aliases
            Assert.AreEqual(1m, ApparentPower.Parse("1 W", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ReactivePower.Parse("1 W", Inv).AsSI, 1e-9m);
        }

        // -------------------- PRESSURE --------------------
        [TestMethod]
        public void Pressure_Stupid()
        {
            Assert.AreEqual(1m, Pressure.Parse("1 Pa", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Pressure.Parse("1 N/m^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Pressure.Parse("1 kg/(m*s^2)", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Pressure.Parse("2 kg/(m*s^2)", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Pressure.Parse("1 (N)/(m^2)", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Pressure.Parse("1 N m^-2", Inv).AsSI, 1e-9m);

            Assert.AreEqual(101325m, Pressure.Parse("101325 Pa", Inv).AsSI, 1e-6m);
            Assert.AreEqual(0.0001m, Pressure.Parse("0.0001 Pa", Inv).AsSI, 1e-12m);
        }

        // -------------------- FORCE (+ aliases) --------------------
        [TestMethod]
        public void Force_And_Friends_Stupid()
        {
            Assert.AreEqual(1m, Force.Parse("1 N", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Force.Parse("1 kg*m/s^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Force.Parse("1 Pa*m^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Force.Parse("2 Pa*m^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Force.Parse("1 (kg*m)/(s^2)", Inv).AsSI, 1e-9m);

            // Force per length (same dims as irradiation group in your list, but still test the parser)
            Assert.AreEqual(1m, ForcePerLength.Parse("1 N/m", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ForcePerLength.Parse("1 kg/s^2", Inv).AsSI, 1e-9m);

            // Force per length alias group
            Assert.AreEqual(1m, Irradiation.Parse("1 N/m", Inv).AsSI, 1e-9m);

            // TorquePerLength (same group as Force)
            Assert.AreEqual(1m, TorquePerLength.Parse("1 N", Inv).AsSI, 1e-9m);

            Assert.AreEqual(9.81m, Force.Parse("9.81 kg*m/s^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1_000_000m, Force.Parse("1000000 N", Inv).AsSI, 1e-6m);
        }

        // -------------------- ELECTRICAL BASICS --------------------
        [TestMethod]
        public void ElectricCharge_Current_Potential_Resistance_Inductance_Stupid()
        {
            // ElectricCharge: C == A*s
            Assert.AreEqual(1m, ElectricCharge.Parse("1 C", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricCharge.Parse("1 A*s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricCharge.Parse("2 A*s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(0.5m, ElectricCharge.Parse("0.5 A*s", Inv).AsSI, 1e-12m);

            // ElectricCurrent: A == C/s
            Assert.AreEqual(1m, ElectricCurrent.Parse("1 A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricCurrent.Parse("1 C/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricCurrent.Parse("2 C/s", Inv).AsSI, 1e-9m);

            // ElectricPotential: V == W/A == J/C
            Assert.AreEqual(1m, ElectricPotential.Parse("1 V", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricPotential.Parse("1 W/A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricPotential.Parse("1 J/C", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricPotential.Parse("2 J/C", Inv).AsSI, 1e-9m);

            // ElectricResistance: Ohm == V/A
            Assert.AreEqual(1m, ElectricResistance.Parse("1 Ohm", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricResistance.Parse("1 V/A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricResistance.Parse("2 V/A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricResistance.Parse("1 W/(A^2)", Inv).AsSI, 1e-9m);

            // ElectricInductance: H == V*s/A
            Assert.AreEqual(1m, ElectricInductance.Parse("1 H", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, ElectricInductance.Parse("1 V*s/A", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricInductance.Parse("2 V*s/A", Inv).AsSI, 1e-9m);

            // Big/small sanity
            Assert.AreEqual(1e-6m, ElectricCurrent.Parse("0.000001 A", Inv).AsSI, 1e-18m);
            Assert.AreEqual(1_000_000m, ElectricPotential.Parse("1000000 V", Inv).AsSI, 1e-6m);
        }

        // -------------------- ELECTRICAL “DENSITY/GRADIENT” TYPES --------------------
        [TestMethod]
        public void ElectricDensitiesAndFields_Stupid()
        {
            // ElectricField is typically V/m
            Assert.AreEqual(1m, ElectricField.Parse("1 V/m", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, ElectricField.Parse("2 V/m", Inv).AsSI, 1e-9m);

            // ElectricChargeDensity often C/m^3
            Assert.AreEqual(1m, ElectricChargeDensity.Parse("1 C/m^3", Inv).AsSI, 1e-9m);

            // ElectricSurfaceChargeDensity often C/m^2
            Assert.AreEqual(1m, ElectricSurfaceChargeDensity.Parse("1 C/m^2", Inv).AsSI, 1e-9m);

            // ElectricCurrentDensity often A/m^2
            Assert.AreEqual(1m, ElectricCurrentDensity.Parse("1 A/m^2", Inv).AsSI, 1e-9m);

          
        }

        // -------------------- KINEMATICS --------------------
        [TestMethod]
        public void Speed_Acceleration_Jerk_Snap_Stupid()
        {
            Assert.AreEqual(1m, Speed.Parse("1 m/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Speed.Parse("2 m/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Speed.Parse("1 m s^-1", Inv).AsSI, 1e-9m);

            Assert.AreEqual(1m, Acceleration.Parse("1 m/s^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(9.81m, Acceleration.Parse("9.81 m/s^2", Inv).AsSI, 1e-9m);

            // Jerk: m/s^3
            Assert.AreEqual(1m, Jerk.Parse("1 m/s^3", Inv).AsSI, 1e-9m);

            // Snap: m/s^4
            Assert.AreEqual(1m, Snap.Parse("1 m/s^4", Inv).AsSI, 1e-9m);
        }

        // -------------------- TIME/FREQUENCY --------------------
        [TestMethod]
        public void Frequency_RotationalSpeed_Stupid()
        {
            Assert.AreEqual(1m, Frequency.Parse("1 Hz", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Frequency.Parse("1/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Frequency.Parse("2/s", Inv).AsSI, 1e-9m);

            // RotationalSpeed is same dimension group
            Assert.AreEqual(1m, RotationalSpeed.Parse("1/s", Inv).AsSI, 1e-9m);
        }

        // -------------------- GEOMETRY --------------------
        [TestMethod]
        public void Area_Volume_VolumeFlow_VolumePerLength_Stupid()
        {
            Assert.AreEqual(1m, Area.Parse("1 m^2", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Area.Parse("1 m*m", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Area.Parse("2 m*m", Inv).AsSI, 1e-9m);

            Assert.AreEqual(1m, Volume.Parse("1 m^3", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Volume.Parse("1 m*m*m", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Volume.Parse("2 m^3", Inv).AsSI, 1e-9m);

            // VolumeFlow: m^3/s
            Assert.AreEqual(1m, VolumeFlow.Parse("1 m^3/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, VolumeFlow.Parse("2 m^3/s", Inv).AsSI, 1e-9m);

            // VolumePerLength: m^2 (same as Area group in your list)
            Assert.AreEqual(1m, VolumePerLength.Parse("1 m^2", Inv).AsSI, 1e-9m);
        }

        // -------------------- MASS / DENSITY / FLOWS --------------------
        [TestMethod]
        public void Density_MassFlow_MassFlux_LinearDensity_SpecificVolume_Stupid()
        {
            Assert.AreEqual(1m, Density.Parse("1 kg/m^3", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, Density.Parse("2 kg/m^3", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, Density.Parse("1 kg*m^-3", Inv).AsSI, 1e-9m);

            Assert.AreEqual(1m, MassFlow.Parse("1 kg/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, MassFlow.Parse("2 kg/s", Inv).AsSI, 1e-9m);

            // MassFlux: kg/(m^2*s)
            Assert.AreEqual(1m, MassFlux.Parse("1 kg/(m^2*s)", Inv).AsSI, 1e-9m);

            // LinearDensity: kg/m
            Assert.AreEqual(1m, LinearDensity.Parse("1 kg/m", Inv).AsSI, 1e-9m);

            // SpecificVolume: m^3/kg
            Assert.AreEqual(1m, SpecificVolume.Parse("1 m^3/kg", Inv).AsSI, 1e-9m);
        }

        // -------------------- VISCOSITIES --------------------
        [TestMethod]
        public void DynamicViscosity_KinematicViscosity_Stupid()
        {
            Assert.AreEqual(1m, DynamicViscosity.Parse("1 Pa*s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, DynamicViscosity.Parse("1 kg/(m*s)", Inv).AsSI, 1e-9m);

            Assert.AreEqual(1m, KinematicViscosity.Parse("1 m^2/s", Inv).AsSI, 1e-9m);
            Assert.AreEqual(2m, KinematicViscosity.Parse("2 m^2/s", Inv).AsSI, 1e-9m);
        }

        // -------------------- THERMAL (NO °C HERE – use K) --------------------
        [TestMethod]
        public void ThermalQuantities_Stupid()
        {
            // SpecificHeatCapacity (alias group with SpecificEntropy)
            Assert.AreEqual(1m, SpecificHeatCapacity.Parse("1 J/(kg*K)", Inv).AsSI, 1e-9m);
            Assert.AreEqual(1m, SpecificEntropy.Parse("1 J/(kg*K)", Inv).AsSI, 1e-9m);

            // Entropy: J/K
            Assert.AreEqual(1m, Entropy.Parse("1 J/K", Inv).AsSI, 1e-9m);

            // ThermalConductivity: W/(m*K)
            Assert.AreEqual(1m, ThermalConductivity.Parse("1 W/(m*K)", Inv).AsSI, 1e-9m);

            // HeatTransferCoefficient: W/(m^2*K)
            Assert.AreEqual(1m, HeatTransferCoefficient.Parse("1 W/(m^2*K)", Inv).AsSI, 1e-9m);

            // CoefficientOfThermalExpansion: 1/K
            Assert.AreEqual(1m, CoefficientOfThermalExpansion.Parse("1/K", Inv).AsSI, 1e-9m);
        }

        // -------------------- MOLAR --------------------
        [TestMethod]
        public void MolarStuff_Stupid()
        {
            // MolarFlow: mol/s
            Assert.AreEqual(1m, MolarFlow.Parse("1 mol/s", Inv).AsSI, 1e-9m);

            // Molarity: mol/m^3
            Assert.AreEqual(1m, Molarity.Parse("1 mol/m^3", Inv).AsSI, 1e-9m);

            // MolarMass: kg/mol
            Assert.AreEqual(1m, MolarMass.Parse("1 kg/mol", Inv).AsSI, 1e-9m);

            // MolarEnergy: J/mol
            Assert.AreEqual(1m, MolarEnergy.Parse("1 J/mol", Inv).AsSI, 1e-9m);

            // MolarEntropy: J/(mol*K)
            Assert.AreEqual(1m, MolarEntropy.Parse("1 J/(mol*K)", Inv).AsSI, 1e-9m);
        }

        
            // -------------------- MAGNETICS --------------------
            [TestMethod]
            public void Magnetics_Stupid()
            {
                // MagneticFlux: Wb == V*s
                Assert.AreEqual(1m, MagneticFlux.Parse("1 V*s", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, MagneticFlux.Parse("2 V*s", Inv).AsSI, 1e-9m);
                Assert.AreEqual(0.000001m, MagneticFlux.Parse("0.000001 V*s", Inv).AsSI, 1e-18m);
                Assert.AreEqual(1000000m, MagneticFlux.Parse("1000000 V*s", Inv).AsSI, 1e-6m);

                // MagneticField: Tesla == Wb/m^2 == V*s/m^2
                Assert.AreEqual(1m, MagneticField.Parse("1 V*s/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, MagneticField.Parse("2 V*s/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(1e-9m, MagneticField.Parse("0.000000001 V*s/m^2", Inv).AsSI, 1e-18m);

                // Magnetization: typically A/m
                Assert.AreEqual(1m, Magnetization.Parse("1 A/m", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, Magnetization.Parse("2 A/m", Inv).AsSI, 1e-9m);

                // Permeability: H/m == (V*s/A)/m == V*s/(A*m)
                Assert.AreEqual(1m, Permeability.Parse("1 V*s/(A*m)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, Permeability.Parse("2 V*s/(A*m)", Inv).AsSI, 1e-9m);

                // Permittivity: F/m == (C/V)/m == (A*s)/(V*m)
                Assert.AreEqual(1m, Permittivity.Parse("1 (A*s)/(V*m)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, Permittivity.Parse("2 (A*s)/(V*m)", Inv).AsSI, 1e-9m);
            }

            // -------------------- ELECTRICAL MATERIAL PROPERTIES --------------------
            [TestMethod]
            public void Conductivity_Resistivity_Stupid()
            {
                // ElectricConductivity: S/m == A/(V*m)  (since S == A/V)
                Assert.AreEqual(1m, ElectricConductivity.Parse("1 A/(V*m)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, ElectricConductivity.Parse("2 A/(V*m)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(0.000001m, ElectricConductivity.Parse("0.000001 A/(V*m)", Inv).AsSI, 1e-18m);

                // ElectricResistivity: Ohm*m == V*m/A
                Assert.AreEqual(1m, ElectricResistivity.Parse("1 V*m/A", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, ElectricResistivity.Parse("2 V*m/A", Inv).AsSI, 1e-9m);
                Assert.AreEqual(1000000m, ElectricResistivity.Parse("1000000 V*m/A", Inv).AsSI, 1e-6m);
            }

            // -------------------- RATES / CHANGE RATES / DENSITIES --------------------
            [TestMethod]
            public void Rates_And_Densities_Stupid()
            {
                // ElectricPotentialChangeRate: V/s
                Assert.AreEqual(1m, ElectricPotentialChangeRate.Parse("1 V/s", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, ElectricPotentialChangeRate.Parse("2 V/s", Inv).AsSI, 1e-9m);

                // PressureChangeRate: Pa/s  (alias group with PowerDensity in your list, but still parse-check)
                Assert.AreEqual(1m, PressureChangeRate.Parse("1 Pa/s", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, PressureChangeRate.Parse("2 Pa/s", Inv).AsSI, 1e-9m);

                // PowerDensity: W/m^3
                Assert.AreEqual(1m, PowerDensity.Parse("1 W/m^3", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, PowerDensity.Parse("2 W/m^3", Inv).AsSI, 1e-9m);

                // ElectricCurrentDensity: A/m^2
                Assert.AreEqual(1m, ElectricCurrentDensity.Parse("1 A/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, ElectricCurrentDensity.Parse("2 A/m^2", Inv).AsSI, 1e-9m);

                // ElectricChargeDensity: C/m^3 == A*s/m^3
                Assert.AreEqual(1m, ElectricChargeDensity.Parse("1 C/m^3", Inv).AsSI, 1e-9m);
                Assert.AreEqual(1m, ElectricChargeDensity.Parse("1 A*s/m^3", Inv).AsSI, 1e-9m);

                // ElectricSurfaceChargeDensity: C/m^2 == A*s/m^2
                Assert.AreEqual(1m, ElectricSurfaceChargeDensity.Parse("1 C/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(1m, ElectricSurfaceChargeDensity.Parse("1 A*s/m^2", Inv).AsSI, 1e-9m);
            }

            // -------------------- HEAT FLUX / IRRADIANCE / HTC --------------------
            [TestMethod]
            public void HeatFlux_Irradiance_HTC_Stupid()
            {
                // HeatFlux and Irradiance are same dimension group in your list: W/m^2
                Assert.AreEqual(1m, HeatFlux.Parse("1 W/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, HeatFlux.Parse("2 W/m^2", Inv).AsSI, 1e-9m);

                Assert.AreEqual(1m, Irradiance.Parse("1 W/m^2", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, Irradiance.Parse("2 W/m^2", Inv).AsSI, 1e-9m);

                // HeatTransferCoefficient: W/(m^2*K)
                Assert.AreEqual(1m, HeatTransferCoefficient.Parse("1 W/(m^2*K)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, HeatTransferCoefficient.Parse("2 W/(m^2*K)", Inv).AsSI, 1e-9m);

                // VolumetricHeatTransferCoefficient: W/(m^3*K)
                Assert.AreEqual(1m, VolumetricHeatTransferCoefficient.Parse("1 W/(m^3*K)", Inv).AsSI, 1e-9m);
                Assert.AreEqual(2m, VolumetricHeatTransferCoefficient.Parse("2 W/(m^3*K)", Inv).AsSI, 1e-9m);

                // Very small / large
                Assert.AreEqual(0.000001m, HeatFlux.Parse("0.000001 W/m^2", Inv).AsSI, 1e-18m);
                Assert.AreEqual(1000000m, HeatTransferCoefficient.Parse("1000000 W/(m^2*K)", Inv).AsSI, 1e-6m);
            }

            // -------------------- “WEIRD BUT VALID” MIXED EXPRESSIONS --------------------
            [TestMethod]
            public void MixAndMatch_Stupid()
            {
                // Energy again via different valid forms
                Assert.AreEqual(10m, Energy.Parse("10 Pa*m^3", Inv).AsSI, 1e-9m);
                Assert.AreEqual(10m, Energy.Parse("10 (kg*m^2)/s^2", Inv).AsSI, 1e-9m);

                // Power via mechanical route
                Assert.AreEqual(10m, Power.Parse("10 (Pa*m^3)/s", Inv).AsSI, 1e-9m);

                // ElectricPotential: V == (kg*m^2)/(s^3*A)
                Assert.AreEqual(1m, ElectricPotential.Parse("1 kg*m^2/(s^3*A)", Inv).AsSI, 1e-9m);

                // MagneticFlux: V*s should match J/A as well (since V*s == (J/C)*s and C == A*s)
                Assert.AreEqual(1m, MagneticFlux.Parse("1 V*s", Inv).AsSI, 1e-9m);
                Assert.AreEqual(1m, MagneticFlux.Parse("1 J/A", Inv).AsSI, 1e-9m);

                // ElectricInductance: H == Ohm*s  (since H = V*s/A and Ohm = V/A)
                Assert.AreEqual(1m, ElectricInductance.Parse("1 Ohm*s", Inv).AsSI, 1e-9m);

                // ElectricResistance: Ohm == kg*m^2/(s^3*A^2)
                Assert.AreEqual(1m, ElectricResistance.Parse("1 kg*m^2/(s^3*A^2)", Inv).AsSI, 1e-9m);

                // Permittivity: F/m == (A*s)/(V*m)
                Assert.AreEqual(1m, Permittivity.Parse("1 (A*s)/(V*m)", Inv).AsSI, 1e-9m);

                // Permeability: H/m == V*s/(A*m)
                Assert.AreEqual(1m, Permeability.Parse("1 V*s/(A*m)", Inv).AsSI, 1e-9m);
            }

        [TestMethod]
        public void Dimensionless_NumberOnly_ShouldWork_ForRatio()
        {
            Assert.AreEqual(10m, Ratio.Parse("10", Inv).AsSI, 1e-12m);
        }

        [TestMethod]
        public void Dimensionless_NumberOnly_ShouldFail_ForLength()
        {
            Assert.ThrowsException<FormatException>(() => Length.Parse("10", Inv));
        }

        [TestMethod]
        public void Dimensionless_Brackets_ShouldWork_ForRatio()
        {
            Assert.AreEqual(10m, Ratio.Parse("10 [-]", Inv).AsSI, 1e-12m);
        }

    }
    }