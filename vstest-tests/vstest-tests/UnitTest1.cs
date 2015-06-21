using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vstest_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 4;
            Assert.AreEqual(4, a);
        }
    }
}
