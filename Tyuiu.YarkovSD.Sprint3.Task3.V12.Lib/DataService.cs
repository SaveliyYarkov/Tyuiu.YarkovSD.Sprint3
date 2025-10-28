using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YarkovSD.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int currentCount = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                
            }

            return maxCount;
        }
    }
}