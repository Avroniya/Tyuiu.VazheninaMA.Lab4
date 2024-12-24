using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WaterInTakeCalc.Lib;

namespace WaterInTakeCalc.Test
{
    [TestClass]
    public class ValidWaterInTakeCalc
    {
        [TestMethod]
        public void TestCalculateWaterForMale()
        {
            // Arrange
            double weight = 70;
            double physicalActivity = 2.5;
            double expected = 3.25;

            // Act
            double result = weight * 0.035 + physicalActivity * 0.5;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCalculateWaterForFemale()
        {
            // Arrange
            double weight = 60;
            double physicalActivity = 3;
            double expected = 2.85;

            // Act
            double result = weight * 0.031 + physicalActivity * 0.5;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
