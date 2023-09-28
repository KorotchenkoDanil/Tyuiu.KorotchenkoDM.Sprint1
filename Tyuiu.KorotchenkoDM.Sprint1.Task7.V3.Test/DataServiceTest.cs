using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint1.Task7.V3.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double x = 0;
            double y = 1;
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
