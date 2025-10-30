using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double a = 0;

            for (int i = 1; i <= 3; i++)
            {
                
                for (int k = 1; k <= 12; k++)
                {
                    double term = (Math.Pow(x, k) + 2) * Math.Sin(k);
                    a += term;
                }
            }

            return Math.Round(a, 3);
        }
    }
}
