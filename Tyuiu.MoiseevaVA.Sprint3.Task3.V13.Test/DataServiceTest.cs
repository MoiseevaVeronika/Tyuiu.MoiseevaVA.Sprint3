using Tyuiu.MoiseevaVA.Sprint3.Task3.V13.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "?sd!! 5gh. s!";
            int wait = 5;
            int res = ds.ConvertStringToInt(value);
            Assert.AreEqual(wait, res);


        }
    }
}
