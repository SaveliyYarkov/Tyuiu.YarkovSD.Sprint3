using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double a = 0;

            for (Convert.ToInt32(startValue); startValue <= stopValue; startValue++)
            {
                a += Math.Sin(startValue) * 0.25;
            }
            return Math.Round(a, 3);
        }
    }
}
