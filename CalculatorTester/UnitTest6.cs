using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFail1()
        {
            int num = -1;
            Radix r = new Radix(num);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFail2()
        {
            int num = 1;
            int rad = 1;
            Radix r = new Radix(num);
            r.ConvertDecimalToAnother(rad);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFail3()
        {
            int num = 1;
            int rad = 17;
            Radix r = new Radix(num);
            r.ConvertDecimalToAnother(rad);
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
       @".\TestDataUT6.csv",
         "TestDataUT6#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestSuc()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            int rad = int.Parse(TestContext.DataRow[1].ToString());
            string expect = TestContext.DataRow[2].ToString();
            Radix r = new Radix(num);
            Assert.AreEqual(expect, r.ConvertDecimalToAnother(rad));
        }

    }
}
