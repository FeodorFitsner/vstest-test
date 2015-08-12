using System;
﻿using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace vstest_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_de_ch_locale_decimal()
        {
            CultureInfo info = new CultureInfo("de-CH");
            var d = System.Convert.ToDecimal("1.0", info);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            return;
            var a = 6;
            Assert.AreEqual(6, a);
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
