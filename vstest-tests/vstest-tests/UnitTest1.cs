using System;
﻿using System.Globalization;
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
        
        [TestMethod] 
        public void TestMethod_IsNumeric3_true_Allow_decimal_white() 
        { 
          const string source = "1234,56";
          var actual = Decimal.Parse(source);
          var expected = 1234.56M;
          Assert.AreEqual(expected, actual); 
        }        
    }
}
