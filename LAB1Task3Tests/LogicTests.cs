using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB1Task3;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Task3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void AllIsLetters()
        {
            string input = "ahdshasjhdajnscxn";
            int dol = Logic.ProportionOfLetters(input);
            Assert.AreEqual(100, dol);
        }
        
        [TestMethod()]
        public void TwentyPercent()
        {
            string input = "ah  9341 .";
            int dol = Logic.ProportionOfLetters(input);
            Assert.AreEqual(20, dol);
        }

        [TestMethod()]
        public void NoLetters()
        {
            string input = "123612893182   ,.,";
            int dol = Logic.ProportionOfLetters(input);
            Assert.AreEqual(0, dol);
        }
    }
}