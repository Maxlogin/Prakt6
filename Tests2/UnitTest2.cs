using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zad_2;

namespace Tests2
{
    [TestClass]
    public class Calculation
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 2;
            double x = 2;
            double expected = 2;
            double output = MainWindow.f(n,x);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 3;
            double x = 0;
            double expected = 0;
            double output = MainWindow.f(n, x);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 4;
            double x = 3.5;
            double expected = Math.Pow(x, n) / n;
            double output = MainWindow.f(n, x);
            Assert.AreEqual(expected, output);
        }
    }
}
