using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint2.Task6.V15.Lib;

namespace Tyuiu.KosovAS.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(8));
            Assert.AreEqual("Вторник", ds.FindDayName(9));
            Assert.AreEqual("Среда", ds.FindDayName(10));
            Assert.AreEqual("Четверг", ds.FindDayName(11));
            Assert.AreEqual("Пятница", ds.FindDayName(12));
            Assert.AreEqual("Суббота", ds.FindDayName(13));
            Assert.AreEqual("Воскресенье", ds.FindDayName(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
            ds.FindDayName(-1);
            });
        }
    }
}
