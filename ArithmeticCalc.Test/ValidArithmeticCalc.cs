using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArithmeticCalc.Lib;

namespace ArithmeticCalc.Test
{
    [TestClass]
    public class ValidArithmeticCalc
    {
        private ArithmeticCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new ArithmeticCalcLib();
        }
        [TestMethod]
        public void TestNaturalLogarithm()
        {
            double result = calculator.CalcNaturalLogarithm(Math.E);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNaturalLogarithmWithNonPositiveArgument()
        {
            double result = calculator.CalcNaturalLogarithm(-1);
        }

        [TestMethod]
        public void TestSine()
        {
            double result = calculator.CalcSin(Math.PI / 2);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestCosine()
        {
            double result = calculator.CalcCos(0);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestTangent()
        {
            double result = calculator.CalcTan(Math.PI / 4);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestPowerOfTen()
        {
            double result = calculator.CalcPowerOfTen(2);
            Assert.AreEqual(100, result);
        }
    }
}
