using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task3.V15.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            Assert.AreEqual(11, ds.Calculate(x));

        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            Assert.AreEqual(0.75, ds.Calculate(x));

        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = 1;
            Assert.AreEqual(256, ds.Calculate(x));

        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -20;
            Assert.AreEqual(-219.95, ds.Calculate(x));
        }
    }
}
