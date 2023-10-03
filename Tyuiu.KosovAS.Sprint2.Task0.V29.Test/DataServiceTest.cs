using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task0.V29.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperatioms()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 735;
            bool[] wait = new bool[6] { false, false, true, true, false, false};
            CollectionAssert.AreEqual(wait, ds.GetCompareOperations(x, y));
        }
    }
}
