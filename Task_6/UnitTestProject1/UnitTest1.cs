using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransferStringToNumberLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Handler handler = new Handler();
            Assert.Equals(handler.Launch("545"), 545);
        }

        [TestMethod]
        [ExpectedException(typeof(StringException))]
        public void TestMethod2()
        {
            Handler handler = new Handler();
            Assert.Equals(handler.Launch("545saasd"), 545);
        }

        [TestMethod]
        [ExpectedException(typeof(StringException))]
        public void TestMethod3()
        {
            Handler handler = new Handler();
            Assert.Equals(handler.Launch(""), 545);
        }
    }
}
