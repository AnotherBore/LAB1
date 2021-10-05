using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB1Task2;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Task2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void RealSquare()
        {
            UInt16 a = 10;
            UInt16 b = 10;
            UInt16 count = Logic.CuttingSquares(a, b);
            Assert.AreEqual(1, count);
        }
        [TestMethod()]
        public void DefaultRectangle()
        {
            UInt16 a = 10;
            UInt16 b = 7;
            UInt16 count = Logic.CuttingSquares(a, b);
            Assert.AreEqual(6, count);
        }
    }
}