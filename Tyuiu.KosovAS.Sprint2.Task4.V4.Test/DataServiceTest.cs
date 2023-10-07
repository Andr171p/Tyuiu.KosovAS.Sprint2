using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task4.V4.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            Assert.AreEqual(8.841, ds.Calculate(x, y));
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            Assert.AreEqual(3.584, ds.Calculate(x, y));
        }
    }
}
