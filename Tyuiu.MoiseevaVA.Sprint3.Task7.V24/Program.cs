using Tyuiu.MoiseevaVA.Sprint3.Task7.V12.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
      
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(" Начало отрезка: " + startValue);
            Console.WriteLine(" Конец отрезка: " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |    F(X)    |");
            Console.WriteLine("+----------+------------+");

            double[] res = ds.GetMassFunction(startValue, stopValue);
            int x = startValue;

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("|{0,9:d} |{1,11:f2} |", x, res[i]);
                x++;
            }

            Console.WriteLine("+----------+------------+");
            Console.ReadKey();
        }
    }
}
