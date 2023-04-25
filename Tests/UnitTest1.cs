using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prakt__6;

namespace Tests
{


    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 123;
            int output = MainWindow.f(input);
            Assert.AreEqual(3, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 123;
            int b = 456;
            int output = MainWindow.f(a) + MainWindow.f(b);
            Assert.AreEqual(9, output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 5;
            int b = 10;
            int output = MainWindow.f(a) + MainWindow.f(b);
            Assert.AreEqual(5, output);
        }
    }
}
