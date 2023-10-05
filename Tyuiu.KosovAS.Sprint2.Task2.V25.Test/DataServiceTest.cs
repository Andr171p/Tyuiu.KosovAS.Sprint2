using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task2.V25.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
