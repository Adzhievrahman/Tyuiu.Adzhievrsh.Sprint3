using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task0.V2.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(1, 9);

            Assert.IsTrue(res > 0);
        }
    }
}