using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void sp()
        {
           this.cal  = new Calculation(10, 5);
        }
        
        [TestMethod]
        public void TestCongMethod1()
        {
            Assert.AreEqual(cal.Execute("+"),15);
        }
        [TestMethod]
        public void TestTruMethod1()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestNhanMethod1()
        {
            Assert.AreEqual(cal.Execute("*"),50);
        }
        [TestMethod]
        public void TestChiaoMethod1()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        public void TestChiaDuMethod1()
        {
            Calculation c = new Calculation(5, 3);
            Assert.AreEqual(c.Execute("/"), 1);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv0Method1()
        {
            Calculation c = new Calculation(3, 0);
            c.Execute("/");
        }
    }
}
