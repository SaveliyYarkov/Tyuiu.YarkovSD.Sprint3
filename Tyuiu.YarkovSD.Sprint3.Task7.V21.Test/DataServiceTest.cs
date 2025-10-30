using Tyuiu.YarkovSD.Sprint3.Task7.V21.Lib;

namespace Tyuiu.YarkovSD.Sprint3.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double[] wait = [30.35, 22.67, 16.01, 10.83, 7.04, 0, -3.46, -8.33, -12.99, -17.33, -21.35];
            var res = ds.GetMassFunction(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
