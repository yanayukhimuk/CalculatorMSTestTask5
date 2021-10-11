namespace CalculatorMSTest.DataDriven
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Text.RegularExpressions;

    [TestClass]
    public class DataDrivenAppMSTest
    {
        readonly CSharpCalculator.Calculator calculator;

        [DataTestMethod]
        [DataRow(6, -3, 3)]
        [DataRow(5, 5, 10)]
        public void SumTest1(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Add(a, b), result);
        }

        [DataTestMethod]
        [DataRow(6, -3, 3)]
        [DataRow(5, 5, 10)]
        public void SumTest2(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Add(a, b), result);
        }

        [DataTestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(10, 2, 8)]
        [DataRow(10, 6, 4)]
        public void SubTest1(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Sub(a, b), result);
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(10, 5, 50)]
        public void MultTest1(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Multiply(a, b), result);
        }


        [DataTestMethod]
        [DataRow(10, 5, 2)]
        [DataRow(10, 2, 5)]
        public void DivTest1(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Divide(a, b), result);
        }

    }
}
