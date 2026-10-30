using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoiseevaVA.Sprint3.Task7.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1; //считаю точки
            double[] M = new double[len]; //создала массив для ответов
            int k = 0; //индекс для массива
            for (int x=startValue;x<=stopValue;x++)
            {
                if ((double)x+1.2==0)
                {
                    M[k] = 0.0;
                }
                else
                {
                    double y = (Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x);
                    M[k] = Math.Round(y, 2);
                }
                k++;
            }
            return M;


        }
    }
}
