using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint1.Task3.V4.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int amount = 7;
            var res = ds.PurchaseAmount(priceNotebook, priceCover, amount);
            var wait = 22.75;
            Assert.AreEqual(wait, res);
        }
    }
}
