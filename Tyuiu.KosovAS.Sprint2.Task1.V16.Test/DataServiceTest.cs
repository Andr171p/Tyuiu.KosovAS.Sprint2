using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task1.V16.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145; int b = 716; int c = 144; int d = 137;
            bool[] res = new bool[6];
            bool[] wait = new bool[6] { true, true, true, false, true, false };

            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));

        }
    }
}
