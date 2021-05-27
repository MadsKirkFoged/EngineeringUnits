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
        public void LenghtCompair()
        {
            UnitsNet.Length L1 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Mile);
            EngineeringUnits.Length L2 = new EngineeringUnits.Length(1, EngineeringUnits.LengthUnit.Mile);


            //UnitsNet has some small numerical-error that show off as big in small units like Nanometer
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Kilometer) -       L1.As(UnitsNet.Units.LengthUnit.Kilometer           ), 4.000000000115023E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hectometer)-       L1.As(UnitsNet.Units.LengthUnit.Hectometer          ), 4.0000000002038405E-05);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Meter)-            L1.As(UnitsNet.Units.LengthUnit.Meter               ), 0.0041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Decimeter)-        L1.As(UnitsNet.Units.LengthUnit.Decimeter           ), 0.041);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Centimeter)-       L1.As(UnitsNet.Units.LengthUnit.Centimeter          ), 0.4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Millimeter)-       L1.As(UnitsNet.Units.LengthUnit.Millimeter          ), 4);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Micrometer)-       L1.As(UnitsNet.Units.LengthUnit.Micrometer          ), 4000);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Nanometer)-        L1.As(UnitsNet.Units.LengthUnit.Nanometer           ), 4000001);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Inch)-             L1.As(UnitsNet.Units.LengthUnit.Inch                ), 0.16);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hand)-             L1.As(UnitsNet.Units.LengthUnit.Hand                ), 0.04);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Foot)-             L1.As(UnitsNet.Units.LengthUnit.Foot                ), 0.014);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Yard)-             L1.As(UnitsNet.Units.LengthUnit.Yard                ), 0.0044);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Chain)-            L1.As(UnitsNet.Units.LengthUnit.Chain               ), 0.0002);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Mile)-             L1.As(UnitsNet.Units.LengthUnit.Mile                ), 0);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.NauticalMile)-     L1.As(UnitsNet.Units.LengthUnit.NauticalMile        ), 2.2E-06);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.LightYear)-        L1.As(UnitsNet.Units.LengthUnit.LightYear           ), 4.3E-19);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit)- L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit    ), 2.74E-14);
            Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Parsec)-           L1.As(UnitsNet.Units.LengthUnit.Parsec              ), 1.3E-19);

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
    }
}
