using Tyuiu.MoiseevaVA.Sprint3.Task1.V26.Lib;
namespace Tyuiu.MoiseevaVA.Sprint3.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 8;
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(" Х= " + value);
            Console.WriteLine(" Начало шага: " + startValue);
            Console.WriteLine(" Конец шага: " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             * ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда=" + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
