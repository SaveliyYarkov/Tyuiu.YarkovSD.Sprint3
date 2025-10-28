using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 1.5;

            do
            {
                value += (Math.Pow(a, startValue) + 1/4) * Math.Sin(startValue);
                startValue++;
            }
            while (value <= 13);
            return Math.Round(value, 3);
        }
    }
}
