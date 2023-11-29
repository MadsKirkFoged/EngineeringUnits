using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests.Functionality
{
    [TestClass]
    public class IsInf
    {
        [TestMethod]
        public void Inf_Test()
        {
            // Arrange
            var unit = new BaseUnit(double.PositiveInfinity, MassFlowUnit.SI.Unit);

            // Act
            var value = unit.As(MassFlowUnit.SI);

            // Assert
            Assert.AreEqual(double.PositiveInfinity, value);
        }


    }
}

