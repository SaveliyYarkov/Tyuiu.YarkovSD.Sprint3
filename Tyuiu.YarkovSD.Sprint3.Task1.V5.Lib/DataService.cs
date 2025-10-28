using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double a = 0;
            while (startValue <= 10)
            {
                a += Math.Cos(startValue) + 1 / (startValue * startValue);
                startValue++;
            }

            return Math.Round(a, 3);
        }
    }
}
}
