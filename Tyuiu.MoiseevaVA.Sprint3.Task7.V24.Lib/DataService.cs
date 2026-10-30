using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoiseevaVA.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;

            double[] valueArray = new double[len]; //массив с ответами

            int index = 0; // индекс для массива

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((double)x + 1.2 == 0)
                {
                    valueArray[index] = 0.0;
                }
                else
                {
                    double y = (Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x); //формула

                    valueArray[index] = Math.Round(y, 2);
                }

                index++; // переходим к следующей ячейке массива
            }

            return valueArray; // возвращаем готовый массив
        }
    }
}
