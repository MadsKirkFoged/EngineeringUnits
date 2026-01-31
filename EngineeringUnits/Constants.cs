using EngineeringUnits.Units;

namespace EngineeringUnits;

public class Constants : BaseUnit
{
    /// <summary>
    /// Gravitational Constant
    /// <br>Value: 6.67430×10−11</br>
    /// <br>Unit: [m3⋅kg–1⋅s–2]</br>
    /// <br>If you are looking for the gravity on Earth use: StandardGravity</br>
    /// </summary>
    public static BaseUnit GravitationalConstant
    {
        get
        {
            UnitSystem unit = ForceUnit.SI * LengthUnit.SI.Pow(2) / MassUnit.SI.Pow(2);
            return new(0.0000000000667408m, unit);
        }
    }

    /// <summary>
    /// Speed Of Light in vacuum
    /// <br>Value: 299792458</br>
    /// <br>Unit: [m⋅s−1]</br>
    /// </summary>
    public static Speed SpeedOfLight => new(299792458, SpeedUnit.SI);

    /// <summary>
    /// Nominal gravitational acceleration of an object in a vacuum near the surface of the Earth
    /// <br>Value: 9.80665</br>
    /// <br>Unit: [m⋅s−2]</br>
    /// </summary>
    public static Acceleration StandardGravity => new(1, AccelerationUnit.StandardGravity);

    /// <summary>
    /// Planck Constant (h)
    /// <br>Value: 6.62607015 × 10−34</br>
    /// <br>Unit: [J⋅s]</br>
    /// </summary>
    public static BaseUnit PlanckConstant
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule / FrequencyUnit.Hertz; // J/Hz = J*s
            return new(6.62607015e-34m, unit);
        }
    }

    /// <summary>
    /// Reduced Planck constant (ħ)
    /// <br>Value: 1.054571817… × 10−34</br>
    /// <br>Unit: [J⋅s]</br>
    /// </summary>
    public static BaseUnit ReducedPlanckConstant
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule / FrequencyUnit.Hertz; // J/Hz = J*s
            return new(1.054571817e-34m, unit);
        }
    }

    /// <summary>
    /// Vacuum electric permittivity (ε₀)
    /// <br>Value: 8.8541878128 × 10−12</br>
    /// <br>Unit: [F⋅m−1]</br>
    /// </summary>
    public static Permittivity VacuumElectricPermittivity => new(8.8541878128e-12m, PermittivityUnit.SI);

    /// <summary>
    /// Vacuum magnetic permeability (μ₀)
    /// <br>Value: 1.25663706212 × 10−6</br>
    /// <br>Unit: [H/m]</br>
    /// </summary>
    public static Permeability VacuumMagneticPermeability => new(1.25663706212e-6m, PermeabilityUnit.SI);

    /// <summary>
    /// Impedance of free space (Z₀)
    /// <br>Value: 376.730313668</br>
    /// <br>Unit: [Ω]</br>
    /// </summary>
    public static ElectricResistance ImpedanceOfFreeSpace => new(376.730313668m, ElectricResistanceUnit.Ohm);

    /// <summary>
    /// Elementary charge (e)
    /// <br>Value: 1.602176634×10−19</br>
    /// <br>Unit: [C]</br>
    /// </summary>
    public static ElectricCharge ElementaryCharge => new(1.602176634e-19m, ElectricChargeUnit.Coulomb);

    /// <summary>
    /// Avogadro constant (N_A)
    /// <br>Value: 6.02214076×10^23</br>
    /// <br>Unit: [mol−1]</br>
    /// </summary>
    public static BaseUnit AvogadroConstant
    {
        get
        {
            UnitSystem unit = AmountOfSubstanceUnit.Mole.Pow(-1);
            return new(6.02214076e23m, unit);
        }
    }

    /// <summary>
    /// Boltzmann constant (k)
    /// <br>Value: 1.380649×10−23</br>
    /// <br>Unit: [J⋅K−1] (same dimension as Entropy)</br>
    /// </summary>
    public static Entropy BoltzmannConstant => new(1.380649e-23m, EntropyUnit.SI);

    /// <summary>
    /// Ideal gas constant (R)
    /// <br>Value: 8.31446261815324</br>
    /// <br>Unit: [J⋅K−1⋅mol−1] (same dimension as MolarEntropy)</br>
    /// </summary>
    public static MolarEntropy IdealGasConstant => new(8.31446261815324m, MolarEntropyUnit.JoulePerMoleKelvin);

    // -------------------------------------------------------------------------
    // NEW “normal” constants requested: 1,2,3,7
    // -------------------------------------------------------------------------

    /// <summary>
    /// Luminous efficacy of monochromatic radiation of frequency 540×10¹² Hz (Kcd)
    /// <br>Value: 683</br>
    /// <br>Unit: [lm⋅W−1]</br>
    /// <br>Exact SI defining constant.</br>
    /// </summary>
    public static BaseUnit LuminousEfficacy540THz
    {
        get
        {
            // lm/W
            UnitSystem unit = LuminousFluxUnit.Lumen / PowerUnit.Watt;
            return new(683m, unit);
        }
    }

    /// <summary>
    /// Standard atmosphere (atm)
    /// <br>Value: 101325</br>
    /// <br>Unit: [Pa]</br>
    /// <br>Exact adopted value.</br>
    /// </summary>
    public static Pressure StandardAtmosphere => new(101325m, PressureUnit.Pascal);

    /// <summary>
    /// Standard-state pressure (p°)
    /// <br>Value: 100000</br>
    /// <br>Unit: [Pa]</br>
    /// <br>Exact adopted value (100 kPa).</br>
    /// </summary>
    public static Pressure StandardStatePressure => new(100000m, PressureUnit.Pascal);

    /// <summary>
    /// Electron volt in joules (eV→J)
    /// <br>Value: 1.602176634×10−19</br>
    /// <br>Unit: [J]</br>
    /// <br>Exact (2022 CODATA / SI definition).</br>
    /// </summary>
    public static Energy ElectronVoltInJoules => new(1.602176634e-19m, EnergyUnit.Joule);

    // -------------------------------------------------------------------------
    // Previously-commented constants - upgraded to strongly typed where possible
    // -------------------------------------------------------------------------

    /// <summary>
    /// Conductance quantum (G₀ = 2e²/h)
    /// <br>Value: 7.748091729…×10−5</br>
    /// <br>Unit: [S]</br>
    /// </summary>
    public static ElectricConductance ConductanceQuantum => new(7.748091729e-5m, ElectricConductanceUnit.SI);

    /// <summary>
    /// Inverse of conductance quantum (G₀⁻¹)
    /// <br>Value: 12906.40372…</br>
    /// <br>Unit: [Ω]</br>
    /// </summary>
    public static ElectricResistance InverseConductanceQuantum => new(12906.40372m, ElectricResistanceUnit.Ohm);

    /// <summary>
    /// Josephson constant (K_J = 2e/h)
    /// <br>Value: 483597.8484…×10⁹</br>
    /// <br>Unit: [Hz⋅V−1]</br>
    /// </summary>
    public static BaseUnit JosephsonConstant
    {
        get
        {
            UnitSystem unit = FrequencyUnit.Hertz / ElectricPotentialUnit.Volt;
            return new(483597.8484e9m, unit);
        }
    }

    /// <summary>
    /// Coulomb constant (kₑ = 1/(4πϵ₀))
    /// <br>Value: 8.987551786170799×10⁹ (computed from ε₀)</br>
    /// <br>Unit: [N⋅m²⋅C−2]</br>
    /// </summary>
    public static BaseUnit CoulombConstant
    {
        get
        {
            UnitSystem unit = ForceUnit.SI * LengthUnit.Meter.Pow(2) / ElectricChargeUnit.Coulomb.Pow(2);
            return new(8.987551786170799e9m, unit);
        }
    }

    /// <summary>
    /// von Klitzing constant (R_K = h/e²)
    /// <br>Value: 25812.80745…</br>
    /// <br>Unit: [Ω]</br>
    /// </summary>
    public static ElectricResistance VonKlitzingConstant => new(25812.80745m, ElectricResistanceUnit.Ohm);

    /// <summary>
    /// Magnetic flux quantum (Φ₀ = h/2e)
    /// <br>Value: 2.067833848…×10−15</br>
    /// <br>Unit: [Wb]</br>
    /// </summary>
    public static MagneticFlux MagneticFluxQuantum => new(2.067833848e-15m, MagneticFluxUnit.Weber);

    /// <summary>
    /// Bohr magneton (μ_B)
    /// <br>Value: 9.2740100657×10−24</br>
    /// <br>Unit: [J⋅T−1]</br>
    /// <br>Note: no dedicated “MagneticDipoleMoment” quantity in your combined list, so kept as BaseUnit.</br>
    /// </summary>
    public static BaseUnit BohrMagneton
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule / MagneticFieldUnit.Tesla;
            return new(9.2740100657e-24m, unit);
        }
    }

    /// <summary>
    /// Nuclear magneton (μ_N)
    /// <br>Value: 5.0507837393×10−27</br>
    /// <br>Unit: [J⋅T−1]</br>
    /// <br>Note: no dedicated “MagneticDipoleMoment” quantity in your combined list, so kept as BaseUnit.</br>
    /// </summary>
    public static BaseUnit NuclearMagneton
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule / MagneticFieldUnit.Tesla;
            return new(5.0507837393e-27m, unit);
        }
    }

    /// <summary>
    /// Fine-structure constant (α)
    /// <br>Value: 7.2973525643×10−3</br>
    /// <br>Unit: [-]</br>
    /// </summary>
    public static BaseUnit FineStructureConstant => new(7.2973525643e-3m, new UnitSystem(1m, null));

    /// <summary>
    /// Inverse fine-structure constant (α⁻¹)
    /// <br>Value: 137.035999177</br>
    /// <br>Unit: [-]</br>
    /// </summary>
    public static BaseUnit InverseFineStructureConstant => new(137.035999177m, new UnitSystem(1m, null));

    /// <summary>
    /// Electron mass (mₑ)
    /// <br>Value: 9.1093837139×10−31</br>
    /// <br>Unit: [kg]</br>
    /// </summary>
    public static Mass ElectronMass => new(9.1093837139e-31m, MassUnit.Kilogram);

    /// <summary>
    /// Proton mass (m_p)
    /// <br>Value: 1.67262192595×10−27</br>
    /// <br>Unit: [kg]</br>
    /// </summary>
    public static Mass ProtonMass => new(1.67262192595e-27m, MassUnit.Kilogram);

    /// <summary>
    /// Neutron mass (m_n)
    /// <br>Value: 1.67492750056×10−27</br>
    /// <br>Unit: [kg]</br>
    /// </summary>
    public static Mass NeutronMass => new(1.67492750056e-27m, MassUnit.Kilogram);

    /// <summary>
    /// Bohr radius (a₀)
    /// <br>Value: 5.29177210544×10−11</br>
    /// <br>Unit: [m]</br>
    /// </summary>
    public static Length BohrRadius => new(5.29177210544e-11m, LengthUnit.Meter);

    /// <summary>
    /// Classical electron radius (rₑ)
    /// <br>Value: 2.8179403205×10−15</br>
    /// <br>Unit: [m]</br>
    /// </summary>
    public static Length ClassicalElectronRadius => new(2.8179403205e-15m, LengthUnit.Meter);

    /// <summary>
    /// Electron g-factor (gₑ)
    /// <br>Value: −2.00231930436092</br>
    /// <br>Unit: [-]</br>
    /// </summary>
    public static BaseUnit ElectronGFactor => new(-2.00231930436092m, new UnitSystem(1m, null));

    /// <summary>
    /// Fermi coupling constant (G_F)
    /// <br>Value: 1.1663787×10−5 GeV−2</br>
    /// <br>Unit (returned here): [J−2] (converted using exact e)</br>
    /// </summary>
    public static BaseUnit FermiCouplingConstant
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule.Pow(-2);
            return new(4.543795662612158e14m, unit);
        }
    }

    /// <summary>
    /// Hartree energy (E_h)
    /// <br>Value: 4.3597447222060×10−18</br>
    /// <br>Unit: [J]</br>
    /// </summary>
    public static Energy HartreeEnergy => new(4.3597447222060e-18m, EnergyUnit.Joule);

    /// <summary>
    /// Quantum of circulation (κ)
    /// <br>Value: 3.6369475467×10−4</br>
    /// <br>Unit: [m²⋅s−1] (same dimension as KinematicViscosity)</br>
    /// </summary>
    public static KinematicViscosity QuantumOfCirculation => new(3.6369475467e-4m, KinematicViscosityUnit.SI);

    /// <summary>
    /// Rydberg constant (R∞)
    /// <br>Value: 10973731.568157</br>
    /// <br>Unit: [m−1]</br>
    /// <br>Note: no dedicated reciprocal-length quantity, so kept as BaseUnit.</br>
    /// </summary>
    public static BaseUnit RydbergConstant
    {
        get
        {
            UnitSystem unit = LengthUnit.Meter.Pow(-1);
            return new(10973731.568157m, unit);
        }
    }

    /// <summary>
    /// Thomson cross section (σₑ)
    /// <br>Value: 6.6524587051×10−29</br>
    /// <br>Unit: [m²]</br>
    /// </summary>
    public static Area ThomsonCrossSection => new(6.6524587051e-29m, AreaUnit.SquareMeter);

    /// <summary>
    /// W-to-Z mass ratio (m_W/m_Z)
    /// <br>Value: 0.8814476728654969</br>
    /// <br>Unit: [-]</br>
    /// </summary>
    public static BaseUnit WToZMassRatio => new(0.8814476728654969m, new UnitSystem(1m, null));

    /// <summary>
    /// Weak mixing angle (on-shell scheme): sin²θ_W
    /// <br>Value: 0.22305</br>
    /// <br>Unit: [-]</br>
    /// </summary>
    public static BaseUnit WeakMixingAngle => new(0.22305m, new UnitSystem(1m, null));

    /// <summary>
    /// Atomic mass constant (u)
    /// <br>Value: 1.66053906892×10−27</br>
    /// <br>Unit: [kg]</br>
    /// </summary>
    public static Mass AtomicMassConstant => new(1.66053906892e-27m, MassUnit.Kilogram);

    /// <summary>
    /// Faraday constant (F)
    /// <br>Value: 96485.33212…</br>
    /// <br>Unit: [C⋅mol−1]</br>
    /// <br>Note: no dedicated “ChargePerAmount” quantity, so kept as BaseUnit.</br>
    /// </summary>
    public static BaseUnit FaradayConstant
    {
        get
        {
            UnitSystem unit = ElectricChargeUnit.Coulomb / AmountOfSubstanceUnit.Mole;
            return new(96485.33212m, unit);
        }
    }

    /// <summary>
    /// Molar mass constant (M_u)
    /// <br>Value: 1.00000000105×10−3</br>
    /// <br>Unit: [kg⋅mol−1]</br>
    /// </summary>
    public static MolarMass MolarMassConstant => new(1.00000000105e-3m, MolarMassUnit.SI);

    /// <summary>
    /// Molar mass of carbon-12
    /// <br>Value: 12.0000000126×10−3</br>
    /// <br>Unit: [kg⋅mol−1]</br>
    /// </summary>
    public static MolarMass MolarMassOfCarbon12 => new(12.0000000126e-3m, MolarMassUnit.SI);

    /// <summary>
    /// Stefan–Boltzmann constant (σ)
    /// <br>Value: 5.670374419…×10−8</br>
    /// <br>Unit: [W⋅m−2⋅K−4]</br>
    /// <br>Note: no dedicated quantity for W⋅m−2⋅K−4, so kept as BaseUnit.</br>
    /// </summary>
    public static BaseUnit StefanBoltzmannConstant
    {
        get
        {
            UnitSystem unit = PowerUnit.Watt / AreaUnit.SquareMeter / TemperatureUnit.Kelvin.Pow(4);
            return new(5.670374419e-8m, unit);
        }
    }

    /// <summary>
    /// First radiation constant (c₁ = 2πhc²)
    /// <br>Value: 3.741771852…×10−16</br>
    /// <br>Unit: [W⋅m²]</br>
    /// </summary>
    public static BaseUnit FirstRadiationConstant
    {
        get
        {
            UnitSystem unit = PowerUnit.Watt * AreaUnit.SquareMeter;
            return new(3.741771852e-16m, unit);
        }
    }

    /// <summary>
    /// First radiation constant for spectral radiance (c₁L = 2hc²)
    /// <br>Value: 1.191042972…×10−16</br>
    /// <br>Unit: [W⋅m²⋅sr−1] (sr treated as dimensionless)</br>
    /// </summary>
    public static BaseUnit FirstRadiationConstantForSpectralRadiance
    {
        get
        {
            UnitSystem unit = PowerUnit.Watt * AreaUnit.SquareMeter;
            return new(1.191042972e-16m, unit);
        }
    }

    /// <summary>
    /// Molar Planck constant (N_A h)
    /// <br>Value: 3.990312712…×10−10</br>
    /// <br>Unit: [J⋅Hz−1⋅mol−1]</br>
    /// </summary>
    public static BaseUnit MolarPlanckConstant
    {
        get
        {
            UnitSystem unit = EnergyUnit.Joule / FrequencyUnit.Hertz / AmountOfSubstanceUnit.Mole;
            return new(3.990312712e-10m, unit);
        }
    }

    /// <summary>
    /// Second radiation constant (c₂ = hc/k)
    /// <br>Value: 1.438776877…×10−2</br>
    /// <br>Unit: [m⋅K]</br>
    /// </summary>
    public static BaseUnit SecondRadiationConstant
    {
        get
        {
            UnitSystem unit = LengthUnit.Meter * TemperatureUnit.Kelvin;
            return new(1.438776877e-2m, unit);
        }
    }

    /// <summary>
    /// Wien wavelength displacement law constant (b = λ_max T)
    /// <br>Value: 2.897771955…×10−3</br>
    /// <br>Unit: [m⋅K]</br>
    /// </summary>
    public static BaseUnit WienWavelengthDisplacementLawConstant
    {
        get
        {
            UnitSystem unit = LengthUnit.Meter * TemperatureUnit.Kelvin;
            return new(2.897771955e-3m, unit);
        }
    }

    /// <summary>
    /// Wien frequency displacement law constant (b′ = ν_max/T)
    /// <br>Value: 5.878925757…×10¹⁰</br>
    /// <br>Unit: [Hz⋅K−1]</br>
    /// </summary>
    public static BaseUnit WienFrequencyDisplacementLawConstant
    {
        get
        {
            UnitSystem unit = FrequencyUnit.Hertz / TemperatureUnit.Kelvin;
            return new(5.878925757e10m, unit);
        }
    }

    /// <summary>
    /// Wien entropy displacement law constant
    /// <br>Value: 3.002916077×10−3</br>
    /// <br>Unit: [m⋅K]</br>
    /// <br>Note: Not present in the NIST “all.pdf” snippet; preserved from your TODO list.</br>
    /// </summary>
    public static BaseUnit WienEntropyDisplacementLawConstant
    {
        get
        {
            UnitSystem unit = LengthUnit.Meter * TemperatureUnit.Kelvin;
            return new(3.002916077e-3m, unit);
        }
    }

    /// <summary>
    /// Hyperfine transition frequency of 133Cs (ΔνCs)
    /// <br>Value: 9192631770</br>
    /// <br>Unit: [Hz]</br>
    /// </summary>
    public static Frequency Cesium133HyperfineTransitionFrequency => new(9192631770m, FrequencyUnit.Hertz);
}