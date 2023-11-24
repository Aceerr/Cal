using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            int n = 0;
            double expect = 1;
            Assert.AreEqual(expect, LuyThuya.Power(x, n));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 3;
            int n = 2;
            double expect = 9;
            Assert.AreEqual(expect, LuyThuya.Power(x, n));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double x = 2;
            int n = -1;
            double expect = 0.5;
            Assert.AreEqual(expect, LuyThuya.Power(x, n));
        }
    }
}
