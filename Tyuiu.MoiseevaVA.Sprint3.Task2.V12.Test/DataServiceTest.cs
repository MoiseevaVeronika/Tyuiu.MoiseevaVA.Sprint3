using Tyuiu.MoiseevaVA.Sprint3.Task2.V12.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.033;
            Assert.AreEqual(wait, res);
        }
    }
}
