using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint1.Task4.V11.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            var res = ds.Calculate(x, y);
            var wait = 0.785;
            Assert.AreEqual(wait, res);
        }
    }
}
