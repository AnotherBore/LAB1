using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB1Task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void IsThreeDigit()
        {
            bool result = Logic.IsDigit(345, 3);
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void NoThreeDigit()
        {
            bool result = Logic.IsDigit(345, 2);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void IsMax()
        {
            UInt16 max = Logic.MaxNum(21471);
            Assert.AreEqual(8, max);
        }
    }
}