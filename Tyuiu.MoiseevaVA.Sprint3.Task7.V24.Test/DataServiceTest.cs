using Tyuiu.MoiseevaVA.Sprint3.Task7.V12.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = {7.83,6.22,6.36,6.96,-0.52,0.00,-3.3,-5.53,-6.25,-6.63,-8.24 };
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
