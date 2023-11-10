using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace CalculatorTester
{
    [TestClass]
    
    public class UnitTest2
    {
        private SimpleEqualation sp;
        [TestInitialize]
        
        
        [TestMethod]
        public void TestCoNghthod1()
        {
            sp = new SimpleEqualation(2, 3);
        }
        [TestMethod]
        public void TestVoNghthod1()
        {
            this.sp = new SimpleEqualation()
        }
        [TestMethod]
        public void TestVoSoNghthod1()
        {
            this.sp = new SimpleEqualation()
        }
    }
}
