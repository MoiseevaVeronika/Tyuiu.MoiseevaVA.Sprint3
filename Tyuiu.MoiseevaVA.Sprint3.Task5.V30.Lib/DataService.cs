using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoiseevaVA.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            // Внешний цикл (всегда от 1 до 3)
            for (int i = 1; i <= 3; i++)
            {
                // Внутренний цикл (всегда от 1 до 11)
                for (int j = 1; j <= 11; j++)
                {
                    sumSeries += (Math.Pow(x, 3) - j) + x;
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
