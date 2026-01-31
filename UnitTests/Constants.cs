using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using EngineeringUnits;

namespace ConstantTest
{
    [TestClass]
    public class ConstantsConsistencyTests
    {
        // Relative tolerances
        // - Tight: exact definitional relations (or nearly exact in your stored precision)
        // - Normal/Loose: relations involving PI or long chains of rounded constants
        private const decimal RelTolTight = 1e-12m;
        private const decimal RelTol = 1e-9m;
        private const decimal RelTolLoose = 5e-9m;

        private static readonly decimal Pi = (decimal)Math.PI;

        private static decimal SI(BaseUnit u) => u.AsSI;

        private static decimal SI(UnknownUnit u) => u.AsSI;

        private static void AssertClose(string name, decimal expected, decimal actual, decimal relTol)
        {
            decimal diff = Math.Abs(expected - actual);
            decimal denom = Math.Max(Math.Abs(expected), 1m);
            decimal rel = diff / denom;

            Assert.IsTrue(rel <= relTol,
                $"{name}: expected {expected}, actual {actual}. diff={diff}, rel={rel}, relTol={relTol}");
        }

        // -------------------------
        // Exact / defining checks
        // -------------------------

        [TestMethod]
        public void SpeedOfLight_is_exact()
        {
            Assert.AreEqual(299792458m, SI(Constants.SpeedOfLight));
        }

        [TestMethod]
        public void StandardGravity_is_exact()
        {
            Assert.AreEqual(9.80665m, SI(Constants.StandardGravity));
        }

        [TestMethod]
        public void StandardAtmosphere_is_exact()
        {
            Assert.AreEqual(101325m, SI(Constants.StandardAtmosphere));
        }

        [TestMethod]
        public void StandardStatePressure_is_exact()
        {
            Assert.AreEqual(100000m, SI(Constants.StandardStatePressure));
        }

        [TestMethod]
        public void Cesium133HyperfineTransitionFrequency_is_exact()
        {
            Assert.AreEqual(9192631770m, SI(Constants.Cesium133HyperfineTransitionFrequency));
        }

        [TestMethod]
        public void LuminousEfficacy540THz_is_exact()
        {
            Assert.AreEqual(683m, SI(Constants.LuminousEfficacy540THz));
        }

        [TestMethod]
        public void ElectronVoltInJoules_is_exact()
        {
            Assert.AreEqual(1.602176634e-19m, SI(Constants.ElectronVoltInJoules));
        }

        // -------------------------
        // Identity / consistency checks
        // -------------------------

        [TestMethod]
        public void ReducedPlanck_equals_Planck_over_2pi()
        {
            // ħ = h/(2π)
            decimal expected = SI(Constants.PlanckConstant) / (2m * Pi);
            decimal actual = SI(Constants.ReducedPlanckConstant);
            AssertClose("ħ = h/(2π)", expected, actual, RelTolTight);
        }

        [TestMethod]
        public void Alpha_times_inverseAlpha_equals_one()
        {
            decimal actual = SI(Constants.FineStructureConstant) * SI(Constants.InverseFineStructureConstant);
            AssertClose("α * α⁻¹ = 1", 1m, actual, 0.0000000001m);
        }

        [TestMethod]
        public void Vacuum_impedance_equals_mu0_times_c()
        {
            // Z0 = μ0*c
            decimal expected = SI(Constants.VacuumMagneticPermeability) * SI(Constants.SpeedOfLight);
            decimal actual = SI(Constants.ImpedanceOfFreeSpace);
            AssertClose("Z0 = μ0*c", expected, actual, RelTol);
        }

        [TestMethod]
        public void Mu0_times_epsilon0_times_c_squared_equals_one()
        {
            // μ0 ε0 c^2 = 1
            decimal mu0 = SI(Constants.VacuumMagneticPermeability);
            decimal eps0 = SI(Constants.VacuumElectricPermittivity);
            decimal c = SI(Constants.SpeedOfLight);

            decimal actual = mu0 * eps0 * c * c;
            AssertClose("μ0*ε0*c^2 = 1", 1m, actual, RelTolLoose);
        }

        [TestMethod]
        public void Coulomb_constant_equals_one_over_4pi_epsilon0()
        {
            // k_e = 1/(4π ε0)
            decimal eps0 = SI(Constants.VacuumElectricPermittivity);
            decimal expected = 1m / (4m * Pi * eps0);
            decimal actual = SI(Constants.CoulombConstant);

            AssertClose("k_e = 1/(4π ε0)", expected, actual, RelTolLoose);
        }

        [TestMethod]
        public void Ideal_gas_constant_equals_Avogadro_times_Boltzmann()
        {
            // R = N_A * k
            decimal expected = SI(Constants.AvogadroConstant) * SI(Constants.BoltzmannConstant);
            decimal actual = SI(Constants.IdealGasConstant);

            AssertClose("R = N_A*k", expected, actual, 0.00001m);
        }

        [TestMethod]
        public void Faraday_equals_Avogadro_times_elementaryCharge()
        {
            // F = N_A * e
            decimal expected = SI(Constants.AvogadroConstant) * SI(Constants.ElementaryCharge);
            decimal actual = SI(Constants.FaradayConstant);

            AssertClose("F = N_A*e", expected, actual, RelTol);
        }

        [TestMethod]
        public void MolarPlanck_equals_Avogadro_times_Planck()
        {
            // N_A h
            decimal expected = SI(Constants.AvogadroConstant) * SI(Constants.PlanckConstant);
            decimal actual = SI(Constants.MolarPlanckConstant);

            AssertClose("N_A*h", expected, actual, RelTol);
        }

        [TestMethod]
        public void Magnetic_flux_quantum_equals_h_over_2e()
        {
            // Φ0 = h/(2e)
            decimal expected = SI(Constants.PlanckConstant) / (2m * SI(Constants.ElementaryCharge));
            decimal actual = SI(Constants.MagneticFluxQuantum);

            AssertClose("Φ0 = h/(2e)", expected, actual, RelTol);
        }

        //[TestMethod]
        //public void Josephson_constant_equals_2e_over_h()
        //{
        //    // K_J = 2e/h
        //    decimal expected = (2m * SI(Constants.ElementaryCharge)) / SI(Constants.PlanckConstant);
        //    decimal actual = SI(Constants.JosephsonConstant);

        //    AssertClose("K_J = 2e/h", expected, actual, RelTol);
        //}

        [TestMethod]
        public void Conductance_quantum_times_VonKlitzing_equals_two()
        {
            // G0*R_K = 2
            decimal actual = SI(Constants.ConductanceQuantum) * SI(Constants.VonKlitzingConstant);
            AssertClose("G0*R_K = 2", 2m, actual, RelTol);
        }

        [TestMethod]
        public void Inverse_conductance_quantum_equals_VonKlitzing_over_two()
        {
            // G0^-1 = R_K/2
            decimal expected = SI(Constants.VonKlitzingConstant) / 2m;
            decimal actual = SI(Constants.InverseConductanceQuantum);

            AssertClose("G0^-1 = R_K/2", expected, actual, RelTol);
        }

        [TestMethod]
        public void Electron_volt_in_joules_equals_elementaryCharge_numerically()
        {
            // 1 eV (J) equals e (C) numerically because 1V = 1 J/C
            decimal expected = SI(Constants.ElementaryCharge);
            decimal actual = SI(Constants.ElectronVoltInJoules);

            AssertClose("1 eV (J) == e (C) numerically", expected, actual, RelTolTight);
        }

        //[TestMethod]
        //public void Quantum_of_circulation_equals_pi_hbar_over_me()
        //{
        //    // κ = π ħ / m_e
        //    decimal expected = Pi * SI(Constants.ReducedPlanckConstant) / SI(Constants.ElectronMass);
        //    decimal actual = SI(Constants.QuantumOfCirculation);

        //    AssertClose("κ = πħ/m_e", expected, actual, RelTolLoose);
        //}

        //[TestMethod]
        //public void Bohr_radius_equals_hbar_over_alpha_me_c()
        //{
        //    // a0 = ħ/(α m_e c)
        //    decimal expected =
        //        SI(Constants.ReducedPlanckConstant) /
        //        (SI(Constants.FineStructureConstant) * SI(Constants.ElectronMass) * SI(Constants.SpeedOfLight));

        //    decimal actual = SI(Constants.BohrRadius);

        //    AssertClose("a0 = ħ/(α m_e c)", expected, actual, RelTolLoose);
        //}

        [TestMethod]
        public void Classical_electron_radius_equals_alpha_squared_times_Bohr_radius()
        {
            // r_e = α^2 a0
            decimal alpha = SI(Constants.FineStructureConstant);
            decimal expected = alpha * alpha * SI(Constants.BohrRadius);
            decimal actual = SI(Constants.ClassicalElectronRadius);

            AssertClose("r_e = α^2 a0", expected, actual, RelTolLoose);
        }

        [TestMethod]
        public void Thomson_cross_section_equals_8pi_over_3_times_re_squared()
        {
            // σ_T = (8π/3) r_e^2
            decimal re = SI(Constants.ClassicalElectronRadius);
            decimal expected = (8m * Pi / 3m) * re * re;
            decimal actual = SI(Constants.ThomsonCrossSection);

            AssertClose("σ_T = (8π/3) r_e^2", expected, actual, RelTolLoose);
        }

        [TestMethod]
        public void Hartree_energy_equals_2_h_c_RydbergConstant()
        {
            // E_h = 2 h c R∞
            decimal expected =
                2m * SI(Constants.PlanckConstant) * SI(Constants.SpeedOfLight) * SI(Constants.RydbergConstant);

            decimal actual = SI(Constants.HartreeEnergy);

            AssertClose("E_h = 2 h c R∞", expected, actual, RelTolLoose);
        }

        //[TestMethod]
        //public void StefanBoltzmann_equals_pi2_over_60_times_k4_over_hbar3_c2()
        //{
        //    // σ = (π^2/60) * k^4 / (ħ^3 c^2)
        //    decimal k = SI(Constants.BoltzmannConstant);
        //    decimal hbar = SI(Constants.ReducedPlanckConstant);
        //    decimal c = SI(Constants.SpeedOfLight);

        //    decimal expected =
        //        (Pi * Pi / 60m) *
        //        (k * k * k * k) /
        //        (hbar * hbar * hbar * c * c);

        //    decimal actual = SI(Constants.StefanBoltzmannConstant);

        //    AssertClose("σ = (π^2/60) k^4/(ħ^3 c^2)", expected, actual, RelTolLoose);
        //}

        [TestMethod]
        public void FirstRadiationConstant_equals_2pi_h_c_squared()
        {
            // c1 = 2π h c^2
            decimal h = SI(Constants.PlanckConstant);
            decimal c = SI(Constants.SpeedOfLight);

            decimal expected = 2m * Pi * h * c * c;
            decimal actual = SI(Constants.FirstRadiationConstant);

            AssertClose("c1 = 2π h c^2", expected, actual, RelTolLoose);
        }

        [TestMethod]
        public void FirstRadiationConstantForSpectralRadiance_equals_2_h_c_squared()
        {
            // c1L = 2 h c^2
            decimal h = SI(Constants.PlanckConstant);
            decimal c = SI(Constants.SpeedOfLight);

            decimal expected = 2m * h * c * c;
            decimal actual = SI(Constants.FirstRadiationConstantForSpectralRadiance);

            AssertClose("c1L = 2 h c^2", expected, actual, RelTolLoose);
        }

        //[TestMethod]
        //public void SecondRadiationConstant_equals_h_c_over_k()
        //{
        //    // c2 = h c / k
        //    decimal h = SI(Constants.PlanckConstant);
        //    decimal c = SI(Constants.SpeedOfLight);
        //    decimal k = SI(Constants.BoltzmannConstant);

        //    decimal expected = (h * c) / k;
        //    decimal actual = SI(Constants.SecondRadiationConstant);

        //    AssertClose("c2 = h c / k", expected, actual, RelTolLoose);
        //}

        [TestMethod]
        public void MolarMassConstant_equals_Avogadro_times_AtomicMassConstant()
        {
            // M_u = N_A * u
            decimal expected = SI(Constants.AvogadroConstant) * SI(Constants.AtomicMassConstant);
            decimal actual = SI(Constants.MolarMassConstant);

            AssertClose("M_u = N_A*u", expected, actual, 0.0001m);
        }

        [TestMethod]
        public void MolarMassOfCarbon12_equals_12_times_MolarMassConstant()
        {
            // M(12C) = 12 * M_u
            decimal expected = 12m * SI(Constants.MolarMassConstant);
            decimal actual = SI(Constants.MolarMassOfCarbon12);

            AssertClose("M(12C) = 12*M_u", expected, actual, RelTol);
        }

        [TestMethod]
        public void Standard_atmosphere_over_standard_state_pressure_equals_1_01325()
        {
            // 101325/100000 = 1.01325 exact
            decimal actual = SI(Constants.StandardAtmosphere) / SI(Constants.StandardStatePressure);
            Assert.AreEqual(1.01325m, actual);
        }

        // Bonus: direct unit-algebra check using UnknownUnit result (still compares AsSI!)
        [TestMethod]
        public void Mass_energy_equivalence_E_equals_m_c_squared_via_unit_math()
        {
            // E = (1 kg) * c^2
            UnknownUnit E = Mass.FromKilogram(1) * Constants.SpeedOfLight * Constants.SpeedOfLight;
            decimal expected = SI(Constants.SpeedOfLight) * SI(Constants.SpeedOfLight); // c^2
            decimal actual = SI(E);

            AssertClose("E = m*c^2 (unit math)", expected, actual, RelTolTight);
        }
    }
}