using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x  - 1 == 0)
                {
                    a[i] = 0.0;
                    i++;
                }
                else
                {
                    a[i] = Math.Round(((2 * Math.Cos(x) + 2)/ 2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                    i++;
                }
            }

            return a;
        }
    }
}