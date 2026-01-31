using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using EngineeringUnits.Units;
using EngineeringUnits.NumberExtensions.NumberToLength;

namespace UnitTests
{
    [TestClass]
    public class LengthEqualityRoundTripTests
    {
        [TestMethod]
        public void Length_Meter_Foot_Meter_roundtrip_equality()
        {
            Length oneMeter = 1.Meter;
            Length inFoot = oneMeter.ToUnit(LengthUnit.Foot);
            Length oneMeterRoundTrip = inFoot.ToUnit(LengthUnit.Meter);

            Assert.IsTrue(oneMeter == inFoot, "1 m should equal the same length expressed in ft.");
            Assert.IsTrue(inFoot == oneMeterRoundTrip, "ft should equal round-tripped m.");
            Assert.IsTrue(oneMeter == oneMeterRoundTrip, "Round-trip should preserve physical equality.");
        }
    }
}