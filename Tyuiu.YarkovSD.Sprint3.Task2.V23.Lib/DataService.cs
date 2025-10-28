using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 1.5;
            double S = 0;

            do
            {
                S += (Math.Pow(a, startValue) + 1/4) * Math.Sin(startValue);
                startValue++;
            }
            while (startValue <= 13);
            return Math.Round(a, 3);
        }
    }
}
