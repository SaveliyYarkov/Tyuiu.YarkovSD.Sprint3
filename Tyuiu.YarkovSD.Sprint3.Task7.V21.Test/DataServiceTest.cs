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
            double[] wait = [28.05, 22.27, 17.01, 12.35, 7.51, 0.0, 1.62, -7.03, -12.99, -17.55, -21.43];
            var res = ds.GetMassFunction(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
