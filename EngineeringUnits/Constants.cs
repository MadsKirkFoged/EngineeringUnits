﻿using EngineeringUnits.Units;

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
            return new(0.0000000000667408, unit);
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

    ///// <summary>
    ///// Planck Constant
    ///// <br>Value: 6.62607004 × 10-34</br>
    ///// <br>Unit: [m2 kg s-1]</br>
    ///// </summary>
    //public static BaseUnit PlanckConstant
    //{

    //    get
    //    {
    //        UnitSystem unit = (EnergyUnit.SI) / (FrequencyUnit.SI);
    //        BaseUnit local = new(6.62607015e-34m, unit);
    //        return local;
    //    }

    //}

    /// <summary>
    /// Vacuum electric permittivity
    /// <br>Value: 8.8541878128 × 10−12</br>
    /// <br>Unit: [F⋅m−1]</br>
    /// </summary>
    public static BaseUnit VacuumElectricPermittivity
    {
        get
        {
            UnitSystem unit = CapacitanceUnit.Farad / LengthUnit.Meter;
            return new(8.8541878128e-12m, unit);
        }
    }

    /// <summary>
    /// Vacuum Magnetic Permeability
    /// <br>Value: 1.25663706212 × 10−6</br>
    /// <br>Unit: [H/m]</br>
    /// </summary>
    public static BaseUnit VacuumMagneticPermeability
    {

        get
        {
            UnitSystem unit = ElectricInductanceUnit.Henry / LengthUnit.Meter;
            return new(1.25663706212e-6m, unit);
        }
    }

    /// <summary>
    /// Impedance of free space
    /// <br>Value: 376.730313668</br>
    /// <br>Unit: [Ω]</br>
    /// </summary>
    public static BaseUnit ImpedanceOfFreeSpace
    {

        get
        {
            UnitSystem unit = ElectricResistanceUnit.Ohm.Unit;
            return new(376.730313668, unit);
        }
    }

    /// <summary>
    /// Elementary charge
    /// <br>Value: 1.602176634×10−19</br>
    /// <br>Unit: [C]</br>
    /// </summary>
    public static BaseUnit ElementaryCharge
    {

        get
        {
            UnitSystem unit = ElectricChargeUnit.Coulomb.Unit;
            return new(1.602176634e-19m, unit);
        }
    }

    /// <summary>
    /// Avogadro constant
    /// <br>Value: 6.02214076×1023</br>
    /// <br>Unit: [Mol-1]</br>
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
    /// Boltzmann constant
    /// <br>Value: 1.380649×10−23</br>
    /// <br>Unit: [J⋅K−1]</br>
    /// </summary>
    public static BaseUnit BoltzmannConstant
    {

        get
        {
            UnitSystem unit = EnergyUnit.Joule / TemperatureUnit.Kelvin;
            return new(1.380649e-23m, unit);
        }
    }

    /// <summary>
    /// Ideal gas constant
    /// <br>Value: 8.31446261815324</br>
    /// <br>Unit: [J⋅K−1⋅mol−1]</br>
    /// </summary>
    public static BaseUnit IdealGasConstant
    {
        get
        {
            UnitSystem unit = MolarEntropyUnit.JoulePerMoleKelvin.Unit;
            return new BaseUnit(8.31446261815324, unit);
        }
    }

    //conductance quantum	7.748091729...×10−5 S[13]

    //Josephson constant	483597.8484...×109 Hz⋅V−1[14]

    //	Coulomb constant	8.9875517923(14)×109 kg⋅m3⋅s−2⋅C−2[15]

    //von Klitzing constant	25812.80745... Ω[16]

    //magnetic flux quantum	2.067833848...×10−15 Wb[17]

    //inverse conductance quantum	12906.40372... Ω[18]

    //Bohr magneton	9.2740100783(28)×10−24 J⋅T−1[19]

    //nuclear magneton	5.0507837461(15)×10−27 J⋅T−1[20]

    //fine-structure constant	7.2973525693(11)×10−3[21]

    //inverse fine-structure constant	137.035999084(21)[22]

    //electron mass	9.1093837015(28)×10−31 kg[23]

    //proton mass	1.67262192369(51)×10−27 kg[24]

    //neutron mass	1.67492749804(95)×10−27 kg[25]

    //Bohr radius	5.29177210903(80)×10−11 m[26]

    //classical electron radius	2.8179403262(13)×10−15 m[27]

    //electron g-factor	−2.00231930436256(35)[28]

    //Fermi coupling constant	1.1663787(6)×10−5 GeV−2[29]

    //Hartree energy	4.3597447222071(85)×10−18 J[30]

    //quantum of circulation	3.6369475516(11)×10−4 m2⋅s−1[31]

    //Rydberg constant	10973731.568160(21) m−1[32]

    //Thomson cross section	6.6524587321(60)×10−29 m2[33]

    //W-to-Z mass ratio	0.88153(17)[34]

    //weak mixing angle	0.22290(30)[35]

    //atomic mass constant	1.66053906660(50)×10−27 kg[36]

    //Faraday constant	96485.33212... C⋅mol−1[37]

    //molar gas constant	8.314462618... J⋅mol−1⋅K−1[38]

    //	molar mass constant	0.99999999965(30)×10−3 kg⋅mol−1[39]

    //Stefan–Boltzmann constant	5.670374419...×10−8 W⋅m−2⋅K−4[40]

    //first radiation constant	3.741771852...×10−16 W⋅m2[41]

    //first radiation constant for spectral radiance	1.191042972...×10−16 W⋅m2⋅sr−1[42]

    //molar mass of carbon-12	11.9999999958(36)×10−3 kg⋅mol−1[43]

    //molar Planck constant	3.990312712...×10−10 J⋅Hz−1⋅mol−1[44]

    //second radiation constant	1.438776877...×10−2 m⋅K[45]

    //Wien wavelength displacement law constant	2.897771955...×10−3 m⋅K[46]

    //Wien frequency displacement law constant	5.878925757...×1010 Hz⋅K−1[47]

    //Wien entropy displacement law constant	3.002916077...×10−3 m⋅K[48]
    //hyperfine transition frequency of 133Cs	9192631770 Hz[10]

}
