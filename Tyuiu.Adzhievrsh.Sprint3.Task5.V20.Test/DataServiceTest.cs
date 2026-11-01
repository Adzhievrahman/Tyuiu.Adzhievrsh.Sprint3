using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSumSeries(5, 1, 1, 3, 6);

            double wait = 50584.322;

            Assert.AreEqual(wait, res);
        }
    }
}