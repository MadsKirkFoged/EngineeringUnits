using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Functionality
{

    [TestClass]
    public class Operators
    {

        [TestMethod]
        public void LengthOperators()
        {
            Length L1 = new(5, LengthUnit.Meter);
            Length L2 = null;
            Length L3 = null;

            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);
            Assert.IsFalse(L2 != L3);

            Assert.IsFalse(L1 == L2);
            Assert.IsFalse(L2 == L1);
            Assert.IsTrue(L2 == L3);

            Assert.IsFalse(L1 >= L2);
            Assert.IsFalse(L2 >= L1);
            Assert.IsTrue(L2 >= L3);

            Assert.IsFalse(L1 <= L2);
            Assert.IsFalse(L2 <= L1);
            Assert.IsTrue(L2 <= L3);

            Assert.IsFalse(L1 < L2);
            Assert.IsFalse(L2 < L1);
            Assert.IsFalse(L2 < L3);

            Assert.IsFalse(L1 > L2);
            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 > L3);
        }

        [TestMethod]
        public void UnknownOperators()
        {
            Length L1 = new(5, LengthUnit.Meter);

            UnknownUnit U1 = L1 * L1;

            UnknownUnit L2 = null;
            UnknownUnit L3 = null;


            Assert.IsTrue(L1 != L2);
            Assert.IsTrue(L2 != L1);
            Assert.IsFalse(L2 != L3);

            Assert.IsFalse(L1 == L2);
            Assert.IsFalse(L2 == L1);
            Assert.IsTrue(L2 == L3);

            Assert.IsFalse(L1 >= L2);
            Assert.IsFalse(L2 >= L1);
            Assert.IsTrue(L2 >= L3);

            Assert.IsFalse(L1 <= L2);
            Assert.IsFalse(L2 <= L1);
            Assert.IsTrue(L2 <= L3);

            Assert.IsFalse(L1 < L2);
            Assert.IsFalse(L2 < L1);
            Assert.IsFalse(L2 < L3);

            Assert.IsFalse(L1 > L2);
            Assert.IsFalse(L2 > L1);
            Assert.IsFalse(L2 > L3);


        }

        [TestMethod]
        public void OperatorsWithNull()
        {
            Length L1 = new(5, LengthUnit.Meter);
            UnknownUnit L2 = null;

            UnknownUnit L3 = L1 * L1;
            Length L4 = null;

            Assert.IsNull(L1 / L2);
            Assert.IsNull(L2 / L1);
            Assert.IsNull(L2 / L2);

            Assert.IsNull(L3 / L4);
            Assert.IsNull(L4 / L3);
            Assert.IsNull(L4 / L4);

            Assert.IsNull(L1 * L2);
            Assert.IsNull(L2 * L1);
            Assert.IsNull(L2 * L2);

            Assert.IsNull(L3 * L4);
            Assert.IsNull(L4 * L3);
            Assert.IsNull(L4 * L4);



        }



        
        [TestMethod]
        public void RatioAdditionIntAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            int R2 = 1;

            // Act
            Ratio sum1 = R2 + R1;
            Ratio sum2 = R1 + R2;

            // Assert
            Assert.AreEqual(11, sum1);
            Assert.AreEqual(11, sum2);

        }

        [TestMethod]
        public void RatioAdditionDoubleAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            double R2 = 1;

            // Act
            Ratio sum1 = R2 + R1;
            Ratio sum2 = R1 + R2;

            // Assert
            Assert.AreEqual(11, sum1);
            Assert.AreEqual(11, sum2);

        }

        [TestMethod]
        public void RatioAdditionDecimalAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            decimal R2 = 1;

            // Act
            Ratio sum1 = R2 + R1;
            Ratio sum2 = R1 + R2;

            // Assert
            Assert.AreEqual(11, sum1);
            Assert.AreEqual(11, sum2);

        }

        [TestMethod]
        public void RatioSubtractionIntAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            int R2 = 1;

            // Act
            Ratio sum1 = R2 - R1;
            Ratio sum2 = R1 - R2;

            // Assert
            Assert.AreEqual(-9, sum1);
            Assert.AreEqual(9, sum2);

        }

        [TestMethod]
        public void RatioSubtractionDoubleAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            double R2 = 1;

            // Act
            Ratio sum1 = R2 - R1;
            Ratio sum2 = R1 - R2;

            // Assert
            Assert.AreEqual(-9, sum1);
            Assert.AreEqual(9, sum2);

        }

        [TestMethod]
        public void RatioSubtractionDecimalAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            decimal R2 = 1;

            // Act
            Ratio sum1 = R2 - R1;
            Ratio sum2 = R1 - R2;

            // Assert
            Assert.AreEqual(-9, sum1);
            Assert.AreEqual(9, sum2);

        }

        [TestMethod]
        public void RatioMultiplicationIntAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            int R2 = 2;

            // Act
            Ratio sum1 = R2 * R1;
            Ratio sum2 = R1 * R2;

            // Assert
            Assert.AreEqual(20, sum1);
            Assert.AreEqual(20, sum2);

        }



        [TestMethod]
        public void RatioMultiplicationDoubleAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            double R2 = 2;

            // Act
            Ratio sum1 = R2 * R1;
            Ratio sum2 = R1 * R2;

            // Assert
            Assert.AreEqual(20, sum1);
            Assert.AreEqual(20, sum2);

        }

        [TestMethod]
        public void RatioMultiplicationDecimalAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            decimal R2 = 2;

            // Act
            Ratio sum1 = R2 * R1;
            Ratio sum2 = R1 * R2;

            // Assert
            Assert.AreEqual(20, sum1);
            Assert.AreEqual(20, sum2);

        }

        [TestMethod]
        public void RatioDivisionIntAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            int R2 = 2;

            // Act
            Ratio sum1 = R2 / R1;
            Ratio sum2 = R1 / R2;

            // Assert
            Assert.AreEqual(0.2, sum1);
            Assert.AreEqual(5, sum2);

        }

        [TestMethod]
        public void RatioDivisionDoubleAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            double R2 = 2;

            // Act
            Ratio sum1 = R2 / R1;
            Ratio sum2 = R1 / R2;

            // Assert
            Assert.AreEqual(0.2, sum1);
            Assert.AreEqual(5, sum2);

        }

        [TestMethod]
        public void RatioDivisionDecimalAndRatio()
        {
            // Arrange
            Ratio R1 = 10;
            decimal R2 = 2;

            // Act
            Ratio sum1 = R2 / R1;
            Ratio sum2 = R1 / R2;

            // Assert
            Assert.AreEqual(0.2, sum1);
            Assert.AreEqual(5, sum2);

        }


    }

}
