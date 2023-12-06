using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint6.Task0.V20.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 9.037;
            Assert.AreEqual(wait, res);
        }
    }
}
