using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
       @".\TestData.csv",
         "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
    
       
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expect = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);

            Assert.AreEqual(expect, c.Execute("+"));
        }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
       @".\TestData2.csv",
         "TestData2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string op = TestContext.DataRow[2].ToString();
            int expect = int.Parse(TestContext.DataRow[3].ToString());
            Calculation c1 = new Calculation(a, b);

            Assert.AreEqual(expect, c1.Execute(op));
        }
    }
}
