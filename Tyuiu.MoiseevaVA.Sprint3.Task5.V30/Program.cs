using Tyuiu.MoiseevaVA.Sprint3.Task5.V30.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task5.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(" X= " + x);
            Console.WriteLine(" Начало шага 1 суммы: " + startValue1);
            Console.WriteLine(" Конец шага 1 суммы: " + stopValue1);
            Console.WriteLine(" Начало шага 2 суммы: " + startValue2);
            Console.WriteLine(" Конец шага 2 суммы: " + stopValue2);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Сумма сумм ряда=" + ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
            Console.ReadKey();
        }
    }
}
