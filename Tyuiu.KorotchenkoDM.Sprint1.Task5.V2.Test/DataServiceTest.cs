using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 32;
            DataService ds = new DataService();
            var res = ds.FahrenheitToСelsius(temp);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
