using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstUnitTestTutorial.Tests
{
    [TestClass]
    public class MyFirstUnitTests
    {
        [TestMethod]
        public void MyFirstUselessTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CalculatorAdd_TwoPositiveNumbers()
        {
            Calculator calc = new Calculator();

            calc.Add(2, 2);

            Assert.AreEqual(4, calc.Result);
        }
    }
}
