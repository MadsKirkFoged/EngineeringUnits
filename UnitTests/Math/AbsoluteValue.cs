using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AbsoluteValue
    {
        [TestMethod]
        public void TestAbsoluteValue01()
        {
            Frequency f1 = Frequency.FromMegahertz(-32);

            string toString = f1.ToString();

            Frequency f2 = f1.Abs();

            Assert.AreEqual(toString, f1.ToString()); // calling Abs should not mutate F1 if it returns F2
        }

        [TestMethod]
        public void TestAbsoluteValue02()
        {
            Frequency f1 = Frequency.FromMegahertz(32);
            decimal baseUnitValue = f1.BaseunitValue;
            string toString = f1.ToString();
            Frequency f2 = f1.Abs();
            UnknownUnit f3 = f1.Abs();

            Assert.AreEqual(baseUnitValue, f1.BaseunitValue);
            Assert.AreEqual(baseUnitValue, f2.BaseunitValue);
            Assert.AreEqual(baseUnitValue, ((BaseUnit)f3).BaseunitValue);

            Assert.AreEqual(toString, f1.ToString());
            Assert.AreEqual(toString, f2.ToString());
            Assert.AreEqual(toString, f3.ToString());
        }

        [TestMethod]
        public void TestAbsoluteValue03()
        {
            Frequency f0 = Frequency.FromMegahertz(32);
            decimal baseUnitValue = f0.BaseunitValue;
            string toString = f0.ToString();

            Frequency f1 = Frequency.FromMegahertz(-32);

            Frequency f2 = f1.Abs();
            UnknownUnit f3 = f1.Abs();

            Assert.AreEqual(baseUnitValue, f2.BaseunitValue);
            Assert.AreEqual(baseUnitValue, ((BaseUnit)f3).BaseunitValue);

            Assert.AreEqual(toString, f2.ToString());
            Assert.AreEqual(toString, f3.ToString());
        }
    }
}
