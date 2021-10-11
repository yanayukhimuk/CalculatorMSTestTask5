using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        public CSharpCalculator.Calculator calculator;


        [TestMethod]
        public void TestSum1()
        {
            Assert.AreEqual(calculator.Add(6, 3), 9);
        }

        [TestMethod]
        public void TestSum2()
        {
            Assert.AreEqual(calculator.Add(6, -3), 3);
        }

        [TestMethod]
        public void TestSum3()
        {
            Assert.AreEqual(calculator.Add(-5, -5), -10);
        }
        [TestMethod]
        public void TestSubstr1()
        {
            Assert.AreEqual(calculator.Sub(-5, -5), 0);
        }

        [TestMethod]
        public void TestSubstr2()
        {
            Assert.AreEqual(calculator.Sub(5, -5), 10);
        }

        [TestMethod]
        public void TestSubstr3()
        {
            Assert.AreEqual(calculator.Sub(5, 5), 0);
        }

        [TestMethod]
        public void TestDivide1()
        {
            Assert.AreEqual(calculator.Divide(5, 5), 1);
        }

        [TestMethod]
        public void TestDivide2()
        {
            Assert.AreEqual(calculator.Divide(5, 1), 5);
        }

        [TestMethod]
        public void TestMult1()
        {
            Assert.AreEqual(calculator.Multiply(5, 5), 25);
        }

        [TestMethod]
        public void TestMult2()
        {
            Assert.AreEqual(calculator.Multiply(5, 1), 5);
        }

        [TestMethod]
        public void TestMult3()
        {
            Assert.AreEqual(calculator.Multiply(5, -5), -25);
        }

        [TestMethod]
        public void TestMult4()
        {
            Assert.AreEqual(calculator.Multiply(-5, -5), 25);
        }
    }
}
