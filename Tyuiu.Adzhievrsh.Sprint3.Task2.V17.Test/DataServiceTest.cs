using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task2.V17.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSeries(1, 10);

            double expected = 1.0;

            Assert.IsTrue(result > 0);
            Assert.IsTrue(result < 10);
        }
    }
}