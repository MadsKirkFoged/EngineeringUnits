using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class AslotOfCalculations
    {
        [TestMethod]
        public void TestAbsoluteValue01()
        {
            Length L1 = new Length(10, LengthUnit.Meter);
            Length L2 = new Length(10, LengthUnit.Centimeter);

            UnknownUnit result1 = 0;
            UnknownUnit result2 = 0;
            UnknownUnit result3 = new Length(10, LengthUnit.Meter);
            UnknownUnit result4 = new Length(10, LengthUnit.Meter);
            UnknownUnit result5 = 0;

            for (int i = 0; i < 50; i++)
            {
                result1 = L1 * L2;
            }

            for (int i = 0; i < 50; i++)
            {
                result2 *= L1;
            }

            for (int i = 0; i < 50; i++)
            {
                result3 += L1;
            }

            for (int i = 0; i < 50; i++)
            {
                result4 -= L1;
            }

            for (int i = 0; i < 50; i++)
            {
                result5 /= L1;
            }





            //Assert.AreEqual(toString, f1.ToString()); // calling Abs should not mutate F1 if it returns F2
        }

       
    }
}
