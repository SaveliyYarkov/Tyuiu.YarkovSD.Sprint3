using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int x = 16; x <= 24; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 10)
                    {
                        sum += d;
                    }
                }
            }

                return sum;
        }
    }
}