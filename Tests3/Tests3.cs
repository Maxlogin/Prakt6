using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ZAD3;
namespace Tests3
{
    [TestClass]
    public class Tests3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0;
            double radius = 0;
            double result = MainWindow.CircleS(radius);
            Assert.AreEqual(x, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double radius = 5;
            double x = 78.5;
            double result = MainWindow.CircleS(radius);
            Assert.AreEqual(x, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double radius = 2.5;
            double x = 19.625;
            double result = MainWindow.CircleS(radius);
            Assert.AreEqual(x, result, 0.001);
        }

    }
}
