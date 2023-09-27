using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint1.Task6.V15.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLettersCount()
        {
            string strTest = "a b c 1 2 3 d";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
