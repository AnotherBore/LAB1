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
            int a = 10;
            int b = 10;
            int count = Logic.CuttingSquares(a, b);
            Assert.AreEqual(1, count);
        }
        [TestMethod()]
        public void DefaultRectangle()
        {
            int a = 10;
            int b = 7;
            int count = Logic.CuttingSquares(a, b);
            Assert.AreEqual(6, count);
        }
    }
}