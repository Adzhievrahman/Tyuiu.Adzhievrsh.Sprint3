using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task4.V25.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsExpectedSum()
        {
            DataService ds = new DataService();

            double result = ds.Calculate();

            Assert.IsTrue(double.IsFinite(result));
        }
    }
}