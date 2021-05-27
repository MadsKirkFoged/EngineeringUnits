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


        }


        [TestMethod]
        public void LenghtCompairStatics()
        {



            Assert.AreEqual(0, UnitsNet.Length.FromKilometers(435).Meters - EngineeringUnits.Length.FromKilometers(435).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromFeet(4356).Meters - EngineeringUnits.Length.FromFeet(4356).Meters, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromYards(95.65).Miles - EngineeringUnits.Length.FromYards(95.65).Miles, 1.4E-07);
            Assert.AreEqual(0, UnitsNet.Length.FromInches(95.6322325).Feet - EngineeringUnits.Length.FromInches(95.6322325).Feet, 0);
            Assert.AreEqual(0, UnitsNet.Length.FromMeters(4454678.945678).Feet - EngineeringUnits.Length.FromMeters(4454678.945678).Feet, 0);


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


        }
    }
}
