using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task6.V9.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCountDivisors_ReturnsCorrectCount()
        {
            DataService ds = new DataService();

            int result = ds.GetSumTheDivisors(19, 30);

            Assert.AreEqual(35, result);
        }
    }
}