using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DeleteCharInString_RemovesP()
        {
            DataService ds = new DataService();

            string result = ds.DeleteCharInString("gdfppf vfpppt p");

            Assert.AreEqual("gdff vft ", result);
        }
    }
}