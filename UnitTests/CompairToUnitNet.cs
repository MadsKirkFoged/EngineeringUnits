using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;

namespace UnitTests
{
    [TestClass]
    public class CompairToUnitNet
    {


        [TestMethod]
        public void LenghtCompair()
        {
            UnitsNet.Length L1 = new UnitsNet.Length(1, UnitsNet.Units.LengthUnit.Mile);
            EngineeringUnits.Length L2 = new EngineeringUnits.Length(1, EngineeringUnits.LengthUnit.Mile);



            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Kilometer) - L1.As(UnitsNet.Units.LengthUnit.Kilometer),0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Hectometer), L1.As(UnitsNet.Units.LengthUnit.Hectometer), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Meter), L1.As(UnitsNet.Units.LengthUnit.Meter), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Decimeter), L1.As(UnitsNet.Units.LengthUnit.Decimeter), 0);

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Centimeter), L1.As(UnitsNet.Units.LengthUnit.Centimeter), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Millimeter), L1.As(UnitsNet.Units.LengthUnit.Millimeter), 0);

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Micrometer), L1.As(UnitsNet.Units.LengthUnit.Micrometer), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Nanometer), L1.As(UnitsNet.Units.LengthUnit.Nanometer), 0);

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Inch), L1.As(UnitsNet.Units.LengthUnit.Inch), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Hand), L1.As(UnitsNet.Units.LengthUnit.Hand), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Foot), L1.As(UnitsNet.Units.LengthUnit.Foot), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Yard), L1.As(UnitsNet.Units.LengthUnit.Yard), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Chain), L1.As(UnitsNet.Units.LengthUnit.Chain), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Mile), L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.NauticalMile), L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.LightYear), L1.As(UnitsNet.Units.LengthUnit.LightYear), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit), L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 0);
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Parsec), L1.As(UnitsNet.Units.LengthUnit.Parsec), 0);





            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Kilometer), L1.As(UnitsNet.Units.LengthUnit.Kilometer));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Hectometer), L1.As(UnitsNet.Units.LengthUnit.Hectometer));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Meter), L1.As(UnitsNet.Units.LengthUnit.Meter));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Decimeter), L1.As(UnitsNet.Units.LengthUnit.Decimeter));

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Centimeter), L1.As(UnitsNet.Units.LengthUnit.Centimeter));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Millimeter), L1.As(UnitsNet.Units.LengthUnit.Millimeter));

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Micrometer), L1.As(UnitsNet.Units.LengthUnit.Micrometer));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Nanometer), L1.As(UnitsNet.Units.LengthUnit.Nanometer));

            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Inch), L1.As(UnitsNet.Units.LengthUnit.Inch));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Hand), L1.As(UnitsNet.Units.LengthUnit.Hand));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Foot), L1.As(UnitsNet.Units.LengthUnit.Foot));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Yard), L1.As(UnitsNet.Units.LengthUnit.Yard));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Chain), L1.As(UnitsNet.Units.LengthUnit.Chain));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Mile), L1.As(UnitsNet.Units.LengthUnit.Mile));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.NauticalMile), L1.As(UnitsNet.Units.LengthUnit.NauticalMile));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.LightYear), L1.As(UnitsNet.Units.LengthUnit.LightYear));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit), L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit));
            Assert.AreEqual(L2.As(EngineeringUnits.LengthUnit.Parsec), L1.As(UnitsNet.Units.LengthUnit.Parsec));


        }

       

    }
}
