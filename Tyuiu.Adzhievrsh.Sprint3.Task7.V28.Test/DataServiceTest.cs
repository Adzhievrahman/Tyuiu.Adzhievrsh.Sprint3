using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task7.V28.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_ReturnsCorrectArrayLength()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
        }

        [TestMethod]
        public void GetMassFunction_ReturnsZeroWhenDenominatorIsZero()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(0, result[2]);
        }
    }
}