using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsFiniteValue()
        {
            DataService ds = new DataService();

            double result = ds.Calculate();

            Assert.IsTrue(double.IsFinite(result));
        }
    }
}