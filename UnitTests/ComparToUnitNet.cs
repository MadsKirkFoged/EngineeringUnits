using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class ComparToUnitNet
    {


        [TestMethod]
        public void Lenghtcompare()
        {
            UnitsNet.Length L1 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Mile);
            EngineeringUnits.Length L2 = new EngineeringUnits.Length(1, EngineeringUnits.LengthUnit.Mile);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Kilometer) - L1.As(UnitsNet.Units.LengthUnit.Kilometer), 4.000000000115023E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hectometer) - L1.As(UnitsNet.Units.LengthUnit.Hectometer), 4.0000000002038405E-05);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Meter) - L1.As(UnitsNet.Units.LengthUnit.Meter), 0.0041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Decimeter) - L1.As(UnitsNet.Units.LengthUnit.Decimeter), 0.041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Centimeter) - L1.As(UnitsNet.Units.LengthUnit.Centimeter), 0.4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Millimeter) - L1.As(UnitsNet.Units.LengthUnit.Millimeter), 4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Micrometer) - L1.As(UnitsNet.Units.LengthUnit.Micrometer), 4000);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Nanometer) - L1.As(UnitsNet.Units.LengthUnit.Nanometer), 4000001);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Inch) - L1.As(UnitsNet.Units.LengthUnit.Inch), 0.16);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hand) - L1.As(UnitsNet.Units.LengthUnit.Hand), 0.04);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Foot) - L1.As(UnitsNet.Units.LengthUnit.Foot), 0.014);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Yard) - L1.As(UnitsNet.Units.LengthUnit.Yard), 0.0044);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Chain) - L1.As(UnitsNet.Units.LengthUnit.Chain), 0.0002);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Mile) - L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.NauticalMile) - L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 2.2E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.LightYear) - L1.As(UnitsNet.Units.LengthUnit.LightYear), 4.3E-19);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit) - L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 2.74E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Parsec) - L1.As(UnitsNet.Units.LengthUnit.Parsec), 1.3E-19);

            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit),
                                        L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit)), 0);
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.Centimeter),
                            L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0);
            Assert.AreEqual(0, HelperClass.Percent(L2.As(EngineeringUnits.LengthUnit.Centimeter),
                L1.As(UnitsNet.Units.LengthUnit.Centimeter)), 0);



            Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromFeet(4356).Meters - EngineeringUnits.Length.FromFeet(4356).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromYards(95.65).Miles - EngineeringUnits.Length.FromYards(95.65).Miles, 1.4E-07);
            Assert.AreEqual(0, UnitsNet.Length.FromInches(95.6322325).Feet - EngineeringUnits.Length.FromInches(95.6322325).Feet, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromMeters(4454678.945678).Feet - EngineeringUnits.Length.FromMeters(4454678.945678).Feet, 0);


        }


        [TestMethod]
        public void AmountCompare()
        {

            UnitsNet.AmountOfSubstance A1 = new UnitsNet.AmountOfSubstance(65.743, UnitsNet.Units.AmountOfSubstanceUnit.Mole);
            EngineeringUnits.AmountOfSubstance A2 = new EngineeringUnits.AmountOfSubstance(65.743, EngineeringUnits.AmountOfSubstanceUnit.Mole);



            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Centimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole), 9.1E-13);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Decimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Kilomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Megamole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Micromole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Millimole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Mole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.AmountOfSubstanceUnit.Nanomole) - A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole), 7.7E-06);


            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Centimole),
                                                    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Centimole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.CentipoundMole),
                                        A1.As(UnitsNet.Units.AmountOfSubstanceUnit.CentipoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Decimole),
                            A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Decimole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.DecipoundMole),
                A1.As(UnitsNet.Units.AmountOfSubstanceUnit.DecipoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Kilomole),
    A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Kilomole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.KilopoundMole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.KilopoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Megamole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Megamole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Micromole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Micromole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.MicropoundMole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MicropoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Millimole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Millimole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.MillipoundMole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.MillipoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Mole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Mole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.Nanomole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.Nanomole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.NanopoundMole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.NanopoundMole)), 0);
            Assert.AreEqual(0, HelperClass.Percent(A2.As(EngineeringUnits.AmountOfSubstanceUnit.PoundMole),
A1.As(UnitsNet.Units.AmountOfSubstanceUnit.PoundMole)), 0);




        }

        [TestMethod]
        public void DurationCompare()
        {

            UnitsNet.Duration A1 = new UnitsNet.Duration(6544444.743, UnitsNet.Units.DurationUnit.Minute);
            EngineeringUnits.Duration A2 = new EngineeringUnits.Duration(6544444.743, EngineeringUnits.DurationUnit.Minute);



            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Day) - A1.As(UnitsNet.Units.DurationUnit.Day), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Hour) - A1.As(UnitsNet.Units.DurationUnit.Hour), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Microsecond) - A1.As(UnitsNet.Units.DurationUnit.Microsecond), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Millisecond) - A1.As(UnitsNet.Units.DurationUnit.Millisecond), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Minute) - A1.As(UnitsNet.Units.DurationUnit.Minute), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Nanosecond) - A1.As(UnitsNet.Units.DurationUnit.Nanosecond), 65);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Second) - A1.As(UnitsNet.Units.DurationUnit.Second), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.DurationUnit.Week) - A1.As(UnitsNet.Units.DurationUnit.Week), 0);
        }

        [TestMethod]
        public void ElectriccurrentCompare()
        {

            UnitsNet.ElectricCurrent A1 = new UnitsNet.ElectricCurrent(0.0000546, UnitsNet.Units.ElectricCurrentUnit.Ampere);
            EngineeringUnits.ElectricCurrent A2 = new EngineeringUnits.ElectricCurrent(0.0000546, EngineeringUnits.ElectricCurrentUnit.Ampere);



            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Ampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Ampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Centiampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Centiampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Kiloampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Kiloampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Megaampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Megaampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Microampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Microampere), 0);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Milliampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Milliampere), 7E-18);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Nanoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Nanoampere), 7.3E-12);
            Assert.AreEqual(0, A2.As(EngineeringUnits.ElectricCurrentUnit.Picoampere) - A1.As(UnitsNet.Units.ElectricCurrentUnit.Picoampere), 0);

        }




        [TestMethod]
        public void Masscompare()
        {
            UnitsNet.Mass L1 = new UnitsNet.Mass(5674.889, UnitsNet.Units.MassUnit.Kilogram);
            EngineeringUnits.Mass L2 = new EngineeringUnits.Mass(5674.889, EngineeringUnits.MassUnit.Kilogram);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Centigram) - L1.As(UnitsNet.Units.MassUnit.Centigram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Decigram) - L1.As(UnitsNet.Units.MassUnit.Decigram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Dekagram) - L1.As(UnitsNet.Units.MassUnit.Decagram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.EarthMass) - L1.As(UnitsNet.Units.MassUnit.EarthMass), 9.5E-20);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Grain) - L1.As(UnitsNet.Units.MassUnit.Grain), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Gram) - L1.As(UnitsNet.Units.MassUnit.Gram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Hectogram) - L1.As(UnitsNet.Units.MassUnit.Hectogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Kilogram) - L1.As(UnitsNet.Units.MassUnit.Kilogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Microgram) - L1.As(UnitsNet.Units.MassUnit.Microgram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Milligram) - L1.As(UnitsNet.Units.MassUnit.Milligram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Nanogram) - L1.As(UnitsNet.Units.MassUnit.Nanogram), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Ounce) - L1.As(UnitsNet.Units.MassUnit.Ounce), 0.0003);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Pound) - L1.As(UnitsNet.Units.MassUnit.Pound), 1.9E-12);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.ShortTon) - L1.As(UnitsNet.Units.MassUnit.ShortTon), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Stone) - L1.As(UnitsNet.Units.MassUnit.Stone), 0.0008);
            Assert.AreEqual(0, L2.As(EngineeringUnits.MassUnit.Tonne) - L1.As(UnitsNet.Units.MassUnit.Tonne), 0);

            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }


        [TestMethod]
        public void Temperaturecompare()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.Kelvin);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.Kelvin);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 1.2E-13);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);


            //Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);



        }

        [TestMethod]
        public void Temperaturecompare2()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeCelsius);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeCelsius);



            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 0);





        }

        [TestMethod]
        public void Temperaturecompare3()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeFahrenheit);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeFahrenheit);



            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);





        }

        [TestMethod]
        public void Temperaturecompare4()
        {
            UnitsNet.Temperature L1 = new UnitsNet.Temperature(657.4, UnitsNet.Units.TemperatureUnit.DegreeRankine);
            EngineeringUnits.Temperature L2 = new EngineeringUnits.Temperature(657.4, EngineeringUnits.TemperatureUnit.DegreeRankine);

            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeCelsius) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeCelsius), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeFahrenheit) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeFahrenheit), 5.7E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.Kelvin) - L1.As(UnitsNet.Units.TemperatureUnit.Kelvin), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.TemperatureUnit.DegreeRankine) - L1.As(UnitsNet.Units.TemperatureUnit.DegreeRankine), 2.3E-13);


        }
    }
}
