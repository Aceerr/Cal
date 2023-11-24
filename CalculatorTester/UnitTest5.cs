using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
using System.Collections.Generic;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
   
        public void TestPoli1()
        {
            int n = 1;
            List<int> a = new List<int> { 1, 2, 3 };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestPoli2()
        {
            int n = 2;
            List<int> a = new List<int> {1};
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestPoli3()
        {
            int n = -1;
            List<int> a = new List<int> { };
            Polynomial p = new Polynomial(n, a);
        }
        [TestMethod]
        public void TestPoli4()
        {
            int n = 2;
            double x = 1;
            List<int> a = new List<int> {1,2,3 };
            int expect = 6;
            Polynomial p = new Polynomial(n, a);
            Assert.AreEqual(expect,p.Cal(x));
        }
    }
}
