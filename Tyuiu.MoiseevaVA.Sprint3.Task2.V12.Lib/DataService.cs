using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoiseevaVA.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1.0;

            do
            {
                double denominator = startValue + Math.Pow(value, startValue);
                double term = 300.0 / denominator;
                multiplySeries *= Math.Pow(term, startValue);

                startValue++;
            }
            while (startValue <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}
